<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMPD
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.yearl = New Guna.UI2.WinForms.Guna2TextBox()
        Me.descp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.svbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.cancelbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel1.BorderRadius = 10
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.FillColor = System.Drawing.Color.PaleVioletRed
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(459, 44)
        Me.Guna2Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(56, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PROGRAM ENTRY"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2Panel2.Controls.Add(Me.yearl)
        Me.Guna2Panel2.Controls.Add(Me.descp)
        Me.Guna2Panel2.Controls.Add(Me.pcode)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Location = New System.Drawing.Point(12, 67)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(423, 216)
        Me.Guna2Panel2.TabIndex = 6
        '
        'yearl
        '
        Me.yearl.BorderColor = System.Drawing.Color.Black
        Me.yearl.BorderRadius = 10
        Me.yearl.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.yearl.DefaultText = ""
        Me.yearl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.yearl.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.yearl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.yearl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.yearl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yearl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearl.ForeColor = System.Drawing.Color.Black
        Me.yearl.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yearl.Location = New System.Drawing.Point(144, 134)
        Me.yearl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.yearl.Name = "yearl"
        Me.yearl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.yearl.PlaceholderText = ""
        Me.yearl.SelectedText = ""
        Me.yearl.Size = New System.Drawing.Size(214, 34)
        Me.yearl.TabIndex = 29
        '
        'descp
        '
        Me.descp.BorderColor = System.Drawing.Color.Black
        Me.descp.BorderRadius = 10
        Me.descp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.descp.DefaultText = ""
        Me.descp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.descp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.descp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.descp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.descp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.descp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descp.ForeColor = System.Drawing.Color.Black
        Me.descp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.descp.Location = New System.Drawing.Point(144, 75)
        Me.descp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.descp.Name = "descp"
        Me.descp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.descp.PlaceholderText = ""
        Me.descp.SelectedText = ""
        Me.descp.Size = New System.Drawing.Size(214, 34)
        Me.descp.TabIndex = 28
        '
        'pcode
        '
        Me.pcode.BorderColor = System.Drawing.Color.Black
        Me.pcode.BorderRadius = 10
        Me.pcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pcode.DefaultText = ""
        Me.pcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.pcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.pcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pcode.ForeColor = System.Drawing.Color.Black
        Me.pcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pcode.Location = New System.Drawing.Point(144, 26)
        Me.pcode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pcode.Name = "pcode"
        Me.pcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pcode.PlaceholderText = ""
        Me.pcode.SelectedText = ""
        Me.pcode.Size = New System.Drawing.Size(214, 34)
        Me.pcode.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "YEAR LEVEL "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "DESCRIPTION "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "P CODE "
        '
        'svbtn
        '
        Me.svbtn.Animated = True
        Me.svbtn.BackColor = System.Drawing.Color.Transparent
        Me.svbtn.BorderRadius = 10
        Me.svbtn.BorderThickness = 1
        Me.svbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.svbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.svbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.svbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.svbtn.FillColor = System.Drawing.Color.White
        Me.svbtn.Font = New System.Drawing.Font("Bernard MT Condensed", 18.0!)
        Me.svbtn.ForeColor = System.Drawing.Color.Crimson
        Me.svbtn.IndicateFocus = True
        Me.svbtn.Location = New System.Drawing.Point(213, 290)
        Me.svbtn.Name = "svbtn"
        Me.svbtn.Size = New System.Drawing.Size(108, 36)
        Me.svbtn.TabIndex = 43
        Me.svbtn.Text = "SAVE"
        Me.svbtn.UseTransparentBackground = True
        '
        'cancelbtn
        '
        Me.cancelbtn.Animated = True
        Me.cancelbtn.BorderRadius = 10
        Me.cancelbtn.BorderThickness = 1
        Me.cancelbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cancelbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cancelbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cancelbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cancelbtn.FillColor = System.Drawing.Color.White
        Me.cancelbtn.Font = New System.Drawing.Font("Bernard MT Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelbtn.ForeColor = System.Drawing.Color.Crimson
        Me.cancelbtn.IndicateFocus = True
        Me.cancelbtn.Location = New System.Drawing.Point(327, 290)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(108, 36)
        Me.cancelbtn.TabIndex = 44
        Me.cancelbtn.Text = "CANCEL"
        '
        'FMPD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(459, 338)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.svbtn)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FMPD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FMPD"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents yearl As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents descp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents svbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cancelbtn As Guna.UI2.WinForms.Guna2Button
End Class
