<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMNOTIF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMNOTIF))
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.bckbtn = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.messagebx = New System.Windows.Forms.TextBox()
        Me.contactbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.clrbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.savebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.bckbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel3.BorderRadius = 10
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Controls.Add(Me.bckbtn)
        Me.Guna2Panel3.Controls.Add(Me.Label3)
        Me.Guna2Panel3.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel3.FillColor = System.Drawing.Color.PaleVioletRed
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(680, 68)
        Me.Guna2Panel3.TabIndex = 7
        '
        'bckbtn
        '
        Me.bckbtn.Image = CType(resources.GetObject("bckbtn.Image"), System.Drawing.Image)
        Me.bckbtn.ImageRotate = 0!
        Me.bckbtn.Location = New System.Drawing.Point(4, 3)
        Me.bckbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bckbtn.Name = "bckbtn"
        Me.bckbtn.Size = New System.Drawing.Size(58, 60)
        Me.bckbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bckbtn.TabIndex = 9
        Me.bckbtn.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(123, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(356, 46)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "URGENT NOTIF"
        '
        'messagebx
        '
        Me.messagebx.BackColor = System.Drawing.Color.Snow
        Me.messagebx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.messagebx.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.messagebx.Location = New System.Drawing.Point(18, 188)
        Me.messagebx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.messagebx.Multiline = True
        Me.messagebx.Name = "messagebx"
        Me.messagebx.Size = New System.Drawing.Size(629, 333)
        Me.messagebx.TabIndex = 10
        '
        'contactbx
        '
        Me.contactbx.Animated = True
        Me.contactbx.BorderColor = System.Drawing.Color.Black
        Me.contactbx.BorderRadius = 10
        Me.contactbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.contactbx.DefaultText = ""
        Me.contactbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.contactbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.contactbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.contactbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.contactbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.contactbx.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactbx.ForeColor = System.Drawing.Color.Black
        Me.contactbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.contactbx.Location = New System.Drawing.Point(18, 112)
        Me.contactbx.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.contactbx.Name = "contactbx"
        Me.contactbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.contactbx.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.contactbx.PlaceholderText = "CONTACT NO."
        Me.contactbx.SelectedText = ""
        Me.contactbx.Size = New System.Drawing.Size(222, 65)
        Me.contactbx.TabIndex = 9
        Me.contactbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'clrbtn
        '
        Me.clrbtn.Animated = True
        Me.clrbtn.BorderRadius = 10
        Me.clrbtn.BorderThickness = 1
        Me.clrbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.clrbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.clrbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.clrbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.clrbtn.FillColor = System.Drawing.Color.White
        Me.clrbtn.Font = New System.Drawing.Font("Bernard MT Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clrbtn.ForeColor = System.Drawing.Color.Crimson
        Me.clrbtn.IndicateFocus = True
        Me.clrbtn.Location = New System.Drawing.Point(500, 597)
        Me.clrbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.clrbtn.Name = "clrbtn"
        Me.clrbtn.Size = New System.Drawing.Size(148, 60)
        Me.clrbtn.TabIndex = 12
        Me.clrbtn.Text = "CLEAR"
        '
        'savebtn
        '
        Me.savebtn.Animated = True
        Me.savebtn.BackColor = System.Drawing.Color.Transparent
        Me.savebtn.BorderRadius = 10
        Me.savebtn.BorderThickness = 1
        Me.savebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.savebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.savebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.savebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.savebtn.FillColor = System.Drawing.Color.White
        Me.savebtn.Font = New System.Drawing.Font("Bernard MT Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savebtn.ForeColor = System.Drawing.Color.Crimson
        Me.savebtn.IndicateFocus = True
        Me.savebtn.Location = New System.Drawing.Point(500, 528)
        Me.savebtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(148, 60)
        Me.savebtn.TabIndex = 11
        Me.savebtn.Text = "SEND"
        Me.savebtn.UseTransparentBackground = True
        '
        'FMNOTIF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(680, 672)
        Me.Controls.Add(Me.clrbtn)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.messagebx)
        Me.Controls.Add(Me.contactbx)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FMNOTIF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FMNOTIF"
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.bckbtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents bckbtn As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents messagebx As TextBox
    Friend WithEvents contactbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents clrbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents savebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
End Class
