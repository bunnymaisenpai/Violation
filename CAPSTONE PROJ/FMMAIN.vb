Imports Guna.UI2.WinForms
Public Class FMMAIN
    Private Sub dashboard_Click(sender As Object, e As EventArgs) Handles dashboard.Click
        pnl_main.Controls.Clear()
        FMDASH.TopLevel = False
        pnl_main.Controls.Add(FMDASH)
        FMDASH.BringToFront()
        FMDASH.Show()
    End Sub

    Private Sub studE_Click(sender As Object, e As EventArgs) Handles studE.Click
        pnl_main.Controls.Clear()
        FMSE.TopLevel = False
        pnl_main.Controls.Add(FMSE)
        FMSE.BringToFront()
        FMSE.Show()
    End Sub

    Private Sub violationbtn_Click(sender As Object, e As EventArgs) Handles violationbtn.Click
        pnl_main.Controls.Clear()
        FMVE.TopLevel = False
        pnl_main.Controls.Add(FMVE)
        FMVE.BringToFront()
        FMVE.Show()
    End Sub

    Private Sub record_Click(sender As Object, e As EventArgs) Handles record.Click
        pnl_main.Controls.Clear()
        FMR.TopLevel = False
        pnl_main.Controls.Add(FMR)
        FMR.BringToFront()
        FMR.Show()
    End Sub

    Private Sub progs_Click(sender As Object, e As EventArgs) Handles progs.Click
        pnl_main.Controls.Clear()
        FMP.TopLevel = False
        pnl_main.Controls.Add(FMP)
        FMP.BringToFront()
        FMP.Show()
    End Sub

    Private Sub sections_Click(sender As Object, e As EventArgs) Handles sections.Click
        pnl_main.Controls.Clear()
        FMSEC.TopLevel = False
        pnl_main.Controls.Add(FMSEC)
        FMSEC.BringToFront()
        FMSEC.Show()
    End Sub

    Private Sub acad_Click(sender As Object, e As EventArgs) Handles acad.Click
        pnl_main.Controls.Clear()
        FMAY.TopLevel = False
        pnl_main.Controls.Add(FMAY)
        FMAY.BringToFront()
        FMAY.Show()
    End Sub

    Private Sub IR_Click(sender As Object, e As EventArgs) Handles IR.Click
        pnl_main.Controls.Clear()
        FMINCIDENT.TopLevel = False
        pnl_main.Controls.Add(FMINCIDENT)
        FMINCIDENT.BringToFront()
        FMINCIDENT.Show()
    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        If MsgBox("Are you sure to Logout? ", vbQuestion + vbYesNo) = vbYes Then
            Me.Hide()
            FMLOGIN.Show()
        End If
    End Sub

    Private Sub pnl_main_Paint(sender As Object, e As PaintEventArgs) Handles pnl_main.Paint

    End Sub

    Private Sub FMMAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class