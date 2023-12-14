<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FMVL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMVL))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.bckbtn = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VLDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.EDIT = New System.Windows.Forms.DataGridViewImageColumn()
        Me.vlcmb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.bckbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VLDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel1.BorderRadius = 10
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.bckbtn)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.FillColor = System.Drawing.Color.PaleVioletRed
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1028, 44)
        Me.Guna2Panel1.TabIndex = 4
        '
        'bckbtn
        '
        Me.bckbtn.BackColor = System.Drawing.Color.Transparent
        Me.bckbtn.Image = CType(resources.GetObject("bckbtn.Image"), System.Drawing.Image)
        Me.bckbtn.ImageRotate = 0!
        Me.bckbtn.Location = New System.Drawing.Point(3, 3)
        Me.bckbtn.Name = "bckbtn"
        Me.bckbtn.Size = New System.Drawing.Size(42, 35)
        Me.bckbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bckbtn.TabIndex = 13
        Me.bckbtn.TabStop = False
        Me.bckbtn.UseTransparentBackground = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(342, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "VIOLATION LIST"
        '
        'VLDataGridView
        '
        Me.VLDataGridView.AllowUserToAddRows = False
        Me.VLDataGridView.AllowUserToDeleteRows = False
        Me.VLDataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.VLDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.VLDataGridView.BackgroundColor = System.Drawing.Color.Pink
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bernard MT Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Pink
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VLDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.VLDataGridView.ColumnHeadersHeight = 30
        Me.VLDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.VLDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EDIT})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LavenderBlush
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.VLDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.VLDataGridView.GridColor = System.Drawing.Color.PaleVioletRed
        Me.VLDataGridView.Location = New System.Drawing.Point(13, 100)
        Me.VLDataGridView.Name = "VLDataGridView"
        Me.VLDataGridView.ReadOnly = True
        Me.VLDataGridView.RowHeadersVisible = False
        Me.VLDataGridView.Size = New System.Drawing.Size(1003, 540)
        Me.VLDataGridView.TabIndex = 8
        Me.VLDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.VLDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.VLDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.VLDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.VLDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.VLDataGridView.ThemeStyle.BackColor = System.Drawing.Color.Pink
        Me.VLDataGridView.ThemeStyle.GridColor = System.Drawing.Color.PaleVioletRed
        Me.VLDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VLDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.VLDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VLDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.VLDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.VLDataGridView.ThemeStyle.HeaderStyle.Height = 30
        Me.VLDataGridView.ThemeStyle.ReadOnly = True
        Me.VLDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.VLDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.VLDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VLDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.VLDataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.VLDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VLDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'EDIT
        '
        Me.EDIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EDIT.HeaderText = ""
        Me.EDIT.Image = CType(resources.GetObject("EDIT.Image"), System.Drawing.Image)
        Me.EDIT.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.EDIT.Name = "EDIT"
        Me.EDIT.ReadOnly = True
        Me.EDIT.Width = 5
        '
        'vlcmb
        '
        Me.vlcmb.BorderColor = System.Drawing.Color.Black
        Me.vlcmb.BorderRadius = 10
        Me.vlcmb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.vlcmb.DefaultText = ""
        Me.vlcmb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.vlcmb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.vlcmb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vlcmb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vlcmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.vlcmb.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vlcmb.ForeColor = System.Drawing.Color.Black
        Me.vlcmb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.vlcmb.Location = New System.Drawing.Point(13, 50)
        Me.vlcmb.Name = "vlcmb"
        Me.vlcmb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.vlcmb.PlaceholderText = "SEARCH STUDENT"
        Me.vlcmb.SelectedText = ""
        Me.vlcmb.Size = New System.Drawing.Size(221, 44)
        Me.vlcmb.TabIndex = 11
        Me.vlcmb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FMVL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(1028, 652)
        Me.Controls.Add(Me.vlcmb)
        Me.Controls.Add(Me.VLDataGridView)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FMVL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.bckbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VLDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents VLDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents EDIT As DataGridViewImageColumn
    Friend WithEvents vlcmb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents bckbtn As Guna.UI2.WinForms.Guna2PictureBox
End Class
