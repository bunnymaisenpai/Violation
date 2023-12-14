<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FMSE
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMSE))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.stlv = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.savebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.STUDENT = New System.Windows.Forms.TabPage()
        Me.CLR1 = New Guna.UI2.WinForms.Guna2Button()
        Me.addbtn = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.seccmb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.img = New System.Windows.Forms.PictureBox()
        Me.ylcmb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.address = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.gendercmb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.age = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.progcmb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.studentno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.fname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.mname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PARENT = New System.Windows.Forms.TabPage()
        Me.rs = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.contact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.guadiann = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.stlv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.STUDENT.SuspendLayout()
        CType(Me.addbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PARENT.SuspendLayout()
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
        Me.Guna2Panel1.Size = New System.Drawing.Size(842, 44)
        Me.Guna2Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(241, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "STUDENT ENTRY"
        '
        'stlv
        '
        Me.stlv.BackColor = System.Drawing.Color.Transparent
        Me.stlv.Image = CType(resources.GetObject("stlv.Image"), System.Drawing.Image)
        Me.stlv.ImageRotate = 0!
        Me.stlv.Location = New System.Drawing.Point(782, 50)
        Me.stlv.Name = "stlv"
        Me.stlv.Size = New System.Drawing.Size(44, 35)
        Me.stlv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.stlv.TabIndex = 7
        Me.stlv.TabStop = False
        Me.stlv.UseTransparentBackground = True
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.Color.Transparent
        Me.savebtn.BorderRadius = 10
        Me.savebtn.BorderThickness = 1
        Me.savebtn.CheckedState.FillColor = System.Drawing.Color.LavenderBlush
        Me.savebtn.CheckedState.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savebtn.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.savebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.savebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.savebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.savebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.savebtn.FillColor = System.Drawing.Color.White
        Me.savebtn.Font = New System.Drawing.Font("Bernard MT Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savebtn.ForeColor = System.Drawing.Color.Crimson
        Me.savebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.savebtn.IndicateFocus = True
        Me.savebtn.Location = New System.Drawing.Point(563, 495)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(102, 39)
        Me.savebtn.TabIndex = 6
        Me.savebtn.Text = "SAVE"
        Me.savebtn.UseTransparentBackground = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.STUDENT)
        Me.TabControl1.Controls.Add(Me.PARENT)
        Me.TabControl1.Font = New System.Drawing.Font("Bernard MT Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 58)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(818, 627)
        Me.TabControl1.TabIndex = 10
        '
        'STUDENT
        '
        Me.STUDENT.BackColor = System.Drawing.Color.Pink
        Me.STUDENT.Controls.Add(Me.CLR1)
        Me.STUDENT.Controls.Add(Me.addbtn)
        Me.STUDENT.Controls.Add(Me.seccmb)
        Me.STUDENT.Controls.Add(Me.img)
        Me.STUDENT.Controls.Add(Me.ylcmb)
        Me.STUDENT.Controls.Add(Me.Label12)
        Me.STUDENT.Controls.Add(Me.Label13)
        Me.STUDENT.Controls.Add(Me.address)
        Me.STUDENT.Controls.Add(Me.Label14)
        Me.STUDENT.Controls.Add(Me.savebtn)
        Me.STUDENT.Controls.Add(Me.gendercmb)
        Me.STUDENT.Controls.Add(Me.age)
        Me.STUDENT.Controls.Add(Me.Label6)
        Me.STUDENT.Controls.Add(Me.Label2)
        Me.STUDENT.Controls.Add(Me.Label11)
        Me.STUDENT.Controls.Add(Me.Label3)
        Me.STUDENT.Controls.Add(Me.progcmb)
        Me.STUDENT.Controls.Add(Me.Label4)
        Me.STUDENT.Controls.Add(Me.Label5)
        Me.STUDENT.Controls.Add(Me.Label8)
        Me.STUDENT.Controls.Add(Me.studentno)
        Me.STUDENT.Controls.Add(Me.fname)
        Me.STUDENT.Controls.Add(Me.mname)
        Me.STUDENT.Controls.Add(Me.lname)
        Me.STUDENT.Font = New System.Drawing.Font("Bernard MT Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STUDENT.ForeColor = System.Drawing.Color.Black
        Me.STUDENT.Location = New System.Drawing.Point(4, 31)
        Me.STUDENT.Name = "STUDENT"
        Me.STUDENT.Padding = New System.Windows.Forms.Padding(3)
        Me.STUDENT.Size = New System.Drawing.Size(810, 592)
        Me.STUDENT.TabIndex = 0
        Me.STUDENT.Text = "STUDENTS INFORMATION"
        '
        'CLR1
        '
        Me.CLR1.BackColor = System.Drawing.Color.Transparent
        Me.CLR1.BorderRadius = 10
        Me.CLR1.BorderThickness = 1
        Me.CLR1.CheckedState.FillColor = System.Drawing.Color.LavenderBlush
        Me.CLR1.CheckedState.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLR1.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.CLR1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.CLR1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.CLR1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CLR1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.CLR1.FillColor = System.Drawing.Color.White
        Me.CLR1.Font = New System.Drawing.Font("Bernard MT Condensed", 18.0!)
        Me.CLR1.ForeColor = System.Drawing.Color.Crimson
        Me.CLR1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.CLR1.IndicateFocus = True
        Me.CLR1.Location = New System.Drawing.Point(683, 495)
        Me.CLR1.Name = "CLR1"
        Me.CLR1.Size = New System.Drawing.Size(102, 39)
        Me.CLR1.TabIndex = 34
        Me.CLR1.Text = "CLEAR"
        Me.CLR1.UseTransparentBackground = True
        '
        'addbtn
        '
        Me.addbtn.BackColor = System.Drawing.Color.Transparent
        Me.addbtn.Image = CType(resources.GetObject("addbtn.Image"), System.Drawing.Image)
        Me.addbtn.ImageRotate = 0!
        Me.addbtn.Location = New System.Drawing.Point(633, 179)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(32, 34)
        Me.addbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.addbtn.TabIndex = 33
        Me.addbtn.TabStop = False
        Me.addbtn.UseTransparentBackground = True
        '
        'seccmb
        '
        Me.seccmb.BackColor = System.Drawing.Color.Transparent
        Me.seccmb.BorderColor = System.Drawing.Color.Transparent
        Me.seccmb.BorderRadius = 10
        Me.seccmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.seccmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.seccmb.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.seccmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.seccmb.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seccmb.ForeColor = System.Drawing.Color.Black
        Me.seccmb.ItemHeight = 30
        Me.seccmb.Items.AddRange(New Object() {"", "A", "B", "C", "D"})
        Me.seccmb.Location = New System.Drawing.Point(463, 195)
        Me.seccmb.Name = "seccmb"
        Me.seccmb.Size = New System.Drawing.Size(164, 36)
        Me.seccmb.TabIndex = 29
        '
        'img
        '
        Me.img.BackColor = System.Drawing.Color.WhiteSmoke
        Me.img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img.Location = New System.Drawing.Point(656, 6)
        Me.img.Name = "img"
        Me.img.Size = New System.Drawing.Size(148, 182)
        Me.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img.TabIndex = 24
        Me.img.TabStop = False
        '
        'ylcmb
        '
        Me.ylcmb.BackColor = System.Drawing.Color.Transparent
        Me.ylcmb.BorderColor = System.Drawing.Color.Transparent
        Me.ylcmb.BorderRadius = 10
        Me.ylcmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ylcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ylcmb.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ylcmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ylcmb.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ylcmb.ForeColor = System.Drawing.Color.Black
        Me.ylcmb.ItemHeight = 30
        Me.ylcmb.Items.AddRange(New Object() {"", "11", "12"})
        Me.ylcmb.Location = New System.Drawing.Point(464, 135)
        Me.ylcmb.Name = "ylcmb"
        Me.ylcmb.Size = New System.Drawing.Size(163, 36)
        Me.ylcmb.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(340, 199)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 22)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "SECTION"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(340, 141)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 22)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "YEAR LEVEL"
        '
        'address
        '
        Me.address.Animated = True
        Me.address.BorderColor = System.Drawing.Color.Transparent
        Me.address.BorderRadius = 10
        Me.address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.address.DefaultText = ""
        Me.address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.address.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.address.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.ForeColor = System.Drawing.Color.Black
        Me.address.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.address.Location = New System.Drawing.Point(148, 310)
        Me.address.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.address.Name = "address"
        Me.address.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.address.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.address.PlaceholderText = ""
        Me.address.SelectedText = ""
        Me.address.Size = New System.Drawing.Size(368, 96)
        Me.address.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 323)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 22)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "ADDRESS"
        '
        'gendercmb
        '
        Me.gendercmb.BackColor = System.Drawing.Color.Transparent
        Me.gendercmb.BorderColor = System.Drawing.Color.Transparent
        Me.gendercmb.BorderRadius = 10
        Me.gendercmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.gendercmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gendercmb.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gendercmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gendercmb.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gendercmb.ForeColor = System.Drawing.Color.Black
        Me.gendercmb.ItemHeight = 30
        Me.gendercmb.Items.AddRange(New Object() {"", "FEMALE", "MALE"})
        Me.gendercmb.Location = New System.Drawing.Point(465, 32)
        Me.gendercmb.Name = "gendercmb"
        Me.gendercmb.Size = New System.Drawing.Size(162, 36)
        Me.gendercmb.TabIndex = 23
        '
        'age
        '
        Me.age.Animated = True
        Me.age.BorderColor = System.Drawing.Color.Transparent
        Me.age.BorderRadius = 10
        Me.age.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.age.DefaultText = ""
        Me.age.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.age.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.age.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.age.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.age.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.age.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.age.ForeColor = System.Drawing.Color.Black
        Me.age.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.age.Location = New System.Drawing.Point(144, 242)
        Me.age.Name = "age"
        Me.age.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.age.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.age.PlaceholderText = ""
        Me.age.SelectedText = ""
        Me.age.Size = New System.Drawing.Size(190, 36)
        Me.age.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(340, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 22)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "GENDER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "STUDENT NO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 249)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 22)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "AGE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "FIRST NAME"
        '
        'progcmb
        '
        Me.progcmb.BackColor = System.Drawing.Color.Transparent
        Me.progcmb.BorderColor = System.Drawing.Color.Transparent
        Me.progcmb.BorderRadius = 10
        Me.progcmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.progcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.progcmb.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.progcmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.progcmb.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.progcmb.ForeColor = System.Drawing.Color.Black
        Me.progcmb.ItemHeight = 30
        Me.progcmb.Items.AddRange(New Object() {"", "ABM", "HUMSS", "ICT", "GAS", "STEM"})
        Me.progcmb.Location = New System.Drawing.Point(464, 84)
        Me.progcmb.Name = "progcmb"
        Me.progcmb.Size = New System.Drawing.Size(163, 36)
        Me.progcmb.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 22)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "MIDDLE NAME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 22)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "LAST NAME"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(340, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 22)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "PROGRAM"
        '
        'studentno
        '
        Me.studentno.Animated = True
        Me.studentno.BorderColor = System.Drawing.Color.Transparent
        Me.studentno.BorderRadius = 10
        Me.studentno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.studentno.DefaultText = ""
        Me.studentno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.studentno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.studentno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.studentno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.studentno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.studentno.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentno.ForeColor = System.Drawing.Color.Black
        Me.studentno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.studentno.Location = New System.Drawing.Point(143, 28)
        Me.studentno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.studentno.Name = "studentno"
        Me.studentno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.studentno.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.studentno.PlaceholderText = "ex. 20-00001"
        Me.studentno.SelectedText = ""
        Me.studentno.Size = New System.Drawing.Size(191, 34)
        Me.studentno.TabIndex = 6
        '
        'fname
        '
        Me.fname.Animated = True
        Me.fname.BorderColor = System.Drawing.Color.Transparent
        Me.fname.BorderRadius = 10
        Me.fname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fname.DefaultText = ""
        Me.fname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.fname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.fname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fname.ForeColor = System.Drawing.Color.Black
        Me.fname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fname.Location = New System.Drawing.Point(143, 78)
        Me.fname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.fname.Name = "fname"
        Me.fname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fname.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.fname.PlaceholderText = ""
        Me.fname.SelectedText = ""
        Me.fname.Size = New System.Drawing.Size(191, 36)
        Me.fname.TabIndex = 7
        '
        'mname
        '
        Me.mname.Animated = True
        Me.mname.BorderColor = System.Drawing.Color.Transparent
        Me.mname.BorderRadius = 10
        Me.mname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mname.DefaultText = ""
        Me.mname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.mname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.mname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mname.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mname.ForeColor = System.Drawing.Color.Black
        Me.mname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mname.Location = New System.Drawing.Point(144, 129)
        Me.mname.Name = "mname"
        Me.mname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mname.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.mname.PlaceholderText = ""
        Me.mname.SelectedText = ""
        Me.mname.Size = New System.Drawing.Size(190, 36)
        Me.mname.TabIndex = 8
        '
        'lname
        '
        Me.lname.Animated = True
        Me.lname.BorderColor = System.Drawing.Color.Transparent
        Me.lname.BorderRadius = 10
        Me.lname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lname.DefaultText = ""
        Me.lname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lname.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lname.ForeColor = System.Drawing.Color.Black
        Me.lname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lname.Location = New System.Drawing.Point(143, 185)
        Me.lname.Name = "lname"
        Me.lname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lname.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.lname.PlaceholderText = ""
        Me.lname.SelectedText = ""
        Me.lname.Size = New System.Drawing.Size(191, 36)
        Me.lname.TabIndex = 9
        '
        'PARENT
        '
        Me.PARENT.BackColor = System.Drawing.Color.LightPink
        Me.PARENT.Controls.Add(Me.rs)
        Me.PARENT.Controls.Add(Me.Label19)
        Me.PARENT.Controls.Add(Me.Label18)
        Me.PARENT.Controls.Add(Me.contact)
        Me.PARENT.Controls.Add(Me.Label17)
        Me.PARENT.Controls.Add(Me.guadiann)
        Me.PARENT.Controls.Add(Me.Label16)
        Me.PARENT.Font = New System.Drawing.Font("Bernard MT Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PARENT.Location = New System.Drawing.Point(4, 31)
        Me.PARENT.Name = "PARENT"
        Me.PARENT.Padding = New System.Windows.Forms.Padding(3)
        Me.PARENT.Size = New System.Drawing.Size(810, 592)
        Me.PARENT.TabIndex = 1
        Me.PARENT.Text = "PARENT INFORMATION"
        '
        'rs
        '
        Me.rs.Animated = True
        Me.rs.BorderColor = System.Drawing.Color.Black
        Me.rs.BorderRadius = 5
        Me.rs.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.rs.DefaultText = ""
        Me.rs.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.rs.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.rs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.rs.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.rs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rs.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.rs.ForeColor = System.Drawing.Color.Black
        Me.rs.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rs.Location = New System.Drawing.Point(203, 199)
        Me.rs.Name = "rs"
        Me.rs.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.rs.PlaceholderText = ""
        Me.rs.SelectedText = ""
        Me.rs.Size = New System.Drawing.Size(539, 31)
        Me.rs.TabIndex = 18
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(21, 199)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(184, 19)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "RELATION TO STUDENT"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Bernard MT Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Maroon
        Me.Label18.Location = New System.Drawing.Point(300, 66)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(193, 28)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "EMERGENCY TO CALL"
        '
        'contact
        '
        Me.contact.Animated = True
        Me.contact.BorderColor = System.Drawing.Color.Black
        Me.contact.BorderRadius = 5
        Me.contact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.contact.DefaultText = ""
        Me.contact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.contact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.contact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.contact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.contact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.contact.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.contact.ForeColor = System.Drawing.Color.Black
        Me.contact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.contact.Location = New System.Drawing.Point(203, 270)
        Me.contact.Name = "contact"
        Me.contact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.contact.PlaceholderText = ""
        Me.contact.SelectedText = ""
        Me.contact.Size = New System.Drawing.Size(541, 31)
        Me.contact.TabIndex = 15
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(21, 278)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(147, 19)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "CONTACT NUMBER"
        '
        'guadiann
        '
        Me.guadiann.Animated = True
        Me.guadiann.BorderColor = System.Drawing.Color.Black
        Me.guadiann.BorderRadius = 5
        Me.guadiann.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.guadiann.DefaultText = ""
        Me.guadiann.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.guadiann.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.guadiann.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.guadiann.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.guadiann.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.guadiann.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.guadiann.ForeColor = System.Drawing.Color.Black
        Me.guadiann.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.guadiann.Location = New System.Drawing.Point(203, 133)
        Me.guadiann.Name = "guadiann"
        Me.guadiann.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.guadiann.PlaceholderText = ""
        Me.guadiann.SelectedText = ""
        Me.guadiann.Size = New System.Drawing.Size(539, 31)
        Me.guadiann.TabIndex = 10
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(19, 133)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(136, 19)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "GUARDIAN NAME"
        '
        'FMSE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(842, 697)
        Me.Controls.Add(Me.stlv)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FMSE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FMSE"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.stlv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.STUDENT.ResumeLayout(False)
        Me.STUDENT.PerformLayout()
        CType(Me.addbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PARENT.ResumeLayout(False)
        Me.PARENT.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents stlv As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents savebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents PARENT As TabPage
    Friend WithEvents STUDENT As TabPage
    Friend WithEvents addbtn As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents seccmb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents img As PictureBox
    Friend WithEvents ylcmb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents address As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents gendercmb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents age As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents progcmb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents studentno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents fname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents mname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents guadiann As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents CLR1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label18 As Label
    Friend WithEvents contact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents rs As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label19 As Label
End Class
