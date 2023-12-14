<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMQR
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMQR))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.qrscan = New System.Windows.Forms.Label()
        Me.QR = New Guna.UI2.WinForms.Guna2Button()
        Me.svebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.scantxt = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel1.BorderRadius = 10
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.qrscan)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.FillColor = System.Drawing.Color.PaleVioletRed
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(446, 44)
        Me.Guna2Panel1.TabIndex = 5
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(6, 3)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(37, 35)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 2
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'qrscan
        '
        Me.qrscan.AutoSize = True
        Me.qrscan.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qrscan.ForeColor = System.Drawing.Color.White
        Me.qrscan.Location = New System.Drawing.Point(96, 3)
        Me.qrscan.Name = "qrscan"
        Me.qrscan.Size = New System.Drawing.Size(265, 38)
        Me.qrscan.TabIndex = 1
        Me.qrscan.Text = "SCAN HERE !!!"
        '
        'QR
        '
        Me.QR.Animated = True
        Me.QR.BorderColor = System.Drawing.Color.Transparent
        Me.QR.BorderRadius = 10
        Me.QR.BorderThickness = 1
        Me.QR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.QR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.QR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.QR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.QR.FillColor = System.Drawing.Color.LavenderBlush
        Me.QR.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold)
        Me.QR.ForeColor = System.Drawing.Color.Black
        Me.QR.IndicateFocus = True
        Me.QR.Location = New System.Drawing.Point(245, 320)
        Me.QR.Name = "QR"
        Me.QR.Size = New System.Drawing.Size(75, 37)
        Me.QR.TabIndex = 18
        '
        'svebtn
        '
        Me.svebtn.Animated = True
        Me.svebtn.BorderRadius = 10
        Me.svebtn.BorderThickness = 1
        Me.svebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.svebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.svebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.svebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.svebtn.FillColor = System.Drawing.Color.White
        Me.svebtn.Font = New System.Drawing.Font("Bernard MT Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.svebtn.ForeColor = System.Drawing.Color.Crimson
        Me.svebtn.IndicateFocus = True
        Me.svebtn.Location = New System.Drawing.Point(326, 320)
        Me.svebtn.Name = "svebtn"
        Me.svebtn.Size = New System.Drawing.Size(103, 37)
        Me.svebtn.TabIndex = 17
        Me.svebtn.Text = "SAVE"
        '
        'scantxt
        '
        Me.scantxt.Location = New System.Drawing.Point(10, 69)
        Me.scantxt.Multiline = True
        Me.scantxt.Name = "scantxt"
        Me.scantxt.Size = New System.Drawing.Size(424, 245)
        Me.scantxt.TabIndex = 14
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Location = New System.Drawing.Point(194, 251)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 38)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(144, 251)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 38)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FMQR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(446, 365)
        Me.Controls.Add(Me.QR)
        Me.Controls.Add(Me.svebtn)
        Me.Controls.Add(Me.scantxt)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FMQR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FMQR"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents qrscan As Label
    Friend WithEvents QR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents svebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents scantxt As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
