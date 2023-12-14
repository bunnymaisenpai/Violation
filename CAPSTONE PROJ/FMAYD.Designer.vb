<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMAYD
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
        Me.sem = New Guna.UI2.WinForms.Guna2TextBox()
        Me.yf = New Guna.UI2.WinForms.Guna2TextBox()
        Me.acode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.yt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.statcmb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cancelbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.svbtn = New Guna.UI2.WinForms.Guna2Button()
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
        Me.Guna2Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(441, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ACADEMIC YEAR ENTRY"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2Panel2.Controls.Add(Me.statcmb)
        Me.Guna2Panel2.Controls.Add(Me.Label6)
        Me.Guna2Panel2.Controls.Add(Me.yt)
        Me.Guna2Panel2.Controls.Add(Me.Label5)
        Me.Guna2Panel2.Controls.Add(Me.sem)
        Me.Guna2Panel2.Controls.Add(Me.yf)
        Me.Guna2Panel2.Controls.Add(Me.acode)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Location = New System.Drawing.Point(18, 56)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(423, 242)
        Me.Guna2Panel2.TabIndex = 7
        '
        'sem
        '
        Me.sem.BorderColor = System.Drawing.Color.Black
        Me.sem.BorderRadius = 10
        Me.sem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sem.DefaultText = ""
        Me.sem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.sem.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.sem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.sem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.sem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.sem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sem.ForeColor = System.Drawing.Color.Black
        Me.sem.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.sem.Location = New System.Drawing.Point(132, 138)
        Me.sem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.sem.Name = "sem"
        Me.sem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.sem.PlaceholderText = ""
        Me.sem.SelectedText = ""
        Me.sem.Size = New System.Drawing.Size(214, 34)
        Me.sem.TabIndex = 29
        '
        'yf
        '
        Me.yf.BorderColor = System.Drawing.Color.Black
        Me.yf.BorderRadius = 10
        Me.yf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.yf.DefaultText = ""
        Me.yf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.yf.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.yf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.yf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.yf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yf.ForeColor = System.Drawing.Color.Black
        Me.yf.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yf.Location = New System.Drawing.Point(132, 51)
        Me.yf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.yf.Name = "yf"
        Me.yf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.yf.PlaceholderText = ""
        Me.yf.SelectedText = ""
        Me.yf.Size = New System.Drawing.Size(214, 34)
        Me.yf.TabIndex = 28
        '
        'acode
        '
        Me.acode.BorderColor = System.Drawing.Color.Black
        Me.acode.BorderRadius = 10
        Me.acode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.acode.DefaultText = ""
        Me.acode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.acode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.acode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.acode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.acode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.acode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acode.ForeColor = System.Drawing.Color.Black
        Me.acode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.acode.Location = New System.Drawing.Point(132, 9)
        Me.acode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.acode.Name = "acode"
        Me.acode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.acode.PlaceholderText = ""
        Me.acode.SelectedText = ""
        Me.acode.Size = New System.Drawing.Size(214, 34)
        Me.acode.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "SEMESTER :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "YEAR FROM :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "AY CODE :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 17)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "YEAR TO :"
        '
        'yt
        '
        Me.yt.BorderColor = System.Drawing.Color.Black
        Me.yt.BorderRadius = 10
        Me.yt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.yt.DefaultText = ""
        Me.yt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.yt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.yt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.yt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.yt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yt.ForeColor = System.Drawing.Color.Black
        Me.yt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yt.Location = New System.Drawing.Point(132, 92)
        Me.yt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.yt.Name = "yt"
        Me.yt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.yt.PlaceholderText = ""
        Me.yt.SelectedText = ""
        Me.yt.Size = New System.Drawing.Size(214, 34)
        Me.yt.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(61, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "STATUS :"
        '
        'statcmb
        '
        Me.statcmb.BackColor = System.Drawing.Color.Transparent
        Me.statcmb.BorderColor = System.Drawing.Color.Black
        Me.statcmb.BorderRadius = 10
        Me.statcmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.statcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.statcmb.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.statcmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.statcmb.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statcmb.ForeColor = System.Drawing.Color.Black
        Me.statcmb.ItemHeight = 30
        Me.statcmb.Items.AddRange(New Object() {"", "OPEN", "CLOSE"})
        Me.statcmb.Location = New System.Drawing.Point(135, 182)
        Me.statcmb.Name = "statcmb"
        Me.statcmb.Size = New System.Drawing.Size(210, 36)
        Me.statcmb.TabIndex = 33
        '
        'cancelbtn
        '
        Me.cancelbtn.Animated = True
        Me.cancelbtn.BorderColor = System.Drawing.Color.Gainsboro
        Me.cancelbtn.BorderRadius = 10
        Me.cancelbtn.BorderThickness = 1
        Me.cancelbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cancelbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cancelbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cancelbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cancelbtn.FillColor = System.Drawing.Color.PaleVioletRed
        Me.cancelbtn.Font = New System.Drawing.Font("Bahnschrift", 14.25!)
        Me.cancelbtn.ForeColor = System.Drawing.Color.White
        Me.cancelbtn.IndicateFocus = True
        Me.cancelbtn.Location = New System.Drawing.Point(337, 303)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(108, 36)
        Me.cancelbtn.TabIndex = 46
        Me.cancelbtn.Text = "CANCEL"
        '
        'svbtn
        '
        Me.svbtn.Animated = True
        Me.svbtn.BorderColor = System.Drawing.Color.Gainsboro
        Me.svbtn.BorderRadius = 10
        Me.svbtn.BorderThickness = 1
        Me.svbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.svbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.svbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.svbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.svbtn.FillColor = System.Drawing.Color.PaleVioletRed
        Me.svbtn.Font = New System.Drawing.Font("Bahnschrift", 14.25!)
        Me.svbtn.ForeColor = System.Drawing.Color.White
        Me.svbtn.IndicateFocus = True
        Me.svbtn.Location = New System.Drawing.Point(223, 303)
        Me.svbtn.Name = "svbtn"
        Me.svbtn.Size = New System.Drawing.Size(108, 36)
        Me.svbtn.TabIndex = 45
        Me.svbtn.Text = "SAVE"
        '
        'FMAYD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(459, 351)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.svbtn)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FMAYD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FMAYD"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents statcmb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents yt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents sem As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents yf As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents acode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cancelbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents svbtn As Guna.UI2.WinForms.Guna2Button
End Class
