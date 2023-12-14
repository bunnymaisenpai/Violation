﻿
Imports System.IO.Ports

Public Class FMNOTIF

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        Dim receiverNumber As String = contactbx.Text
        Dim messageContent As String = messagebx.Text

        ' Check if the receiver's number and message content are not empty
        If String.IsNullOrEmpty(receiverNumber) OrElse String.IsNullOrEmpty(messageContent) Then
            MessageBox.Show("Please enter a receiver's number and a message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Format the AT command to send the message
        Dim atCommand As String = "AT+CMGS=" & """" & receiverNumber & """" & vbCr


        If SerialPort1.IsOpen = True Then
            SerialPort1.Write("AT" & vbCrLf)
            SerialPort1.Write("AT+CMGF=1" & vbCrLf)
            SerialPort1.Write(atCommand)
            Dim response As String = SerialPort1.ReadExisting()
            Do Until response.Contains(">")
                response &= SerialPort1.ReadExisting()
            Loop
            SerialPort1.Write(messageContent & Chr(26))
            System.Threading.Thread.Sleep(5000)
            Dim newresponse = SerialPort1.ReadExisting()
            If newresponse.Contains("OK") Then
                MessageBox.Show("Message sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to send message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Error: Invalid Port", "Port", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub clrbtn_Click(sender As Object, e As EventArgs) Handles clrbtn.Click
        contactbx.Clear()
        messagebx.Focus()
    End Sub

    Private Sub bckbtn_Click(sender As Object, e As EventArgs) Handles bckbtn.Click
        With FMVE
            .Show()
            Me.Hide()
        End With
    End Sub

    Private Sub FMNOTIF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1 = New SerialPort()
        SerialPort1.PortName = "COM11"
        SerialPort1.BaudRate = 115200
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.DataBits = 8
        SerialPort1.Handshake = Handshake.None
        SerialPort1.DtrEnable = True
        SerialPort1.RtsEnable = True
        SerialPort1.NewLine = vbCrLf
        SerialPort1.Open()
        messagebx.Focus()


    End Sub

    Private Sub messagebx_TextChanged(sender As Object, e As EventArgs) Handles messagebx.TextChanged

    End Sub
End Class