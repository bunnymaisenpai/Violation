<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FMR
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMR))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Recordcmb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.RDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.EDIT = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.RDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(287, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "R E C O R D S"
        '
        'Recordcmb
        '
        Me.Recordcmb.BackColor = System.Drawing.Color.Transparent
        Me.Recordcmb.BorderColor = System.Drawing.Color.Black
        Me.Recordcmb.BorderRadius = 10
        Me.Recordcmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Recordcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Recordcmb.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Recordcmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Recordcmb.Font = New System.Drawing.Font("Bodoni MT Condensed", 15.75!)
        Me.Recordcmb.ForeColor = System.Drawing.Color.Black
        Me.Recordcmb.ItemHeight = 30
        Me.Recordcmb.Location = New System.Drawing.Point(12, 65)
        Me.Recordcmb.Name = "Recordcmb"
        Me.Recordcmb.Size = New System.Drawing.Size(185, 36)
        Me.Recordcmb.TabIndex = 5
        '
        'RDataGridView
        '
        Me.RDataGridView.AllowUserToAddRows = False
        Me.RDataGridView.AllowUserToDeleteRows = False
        Me.RDataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.RDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.RDataGridView.BackgroundColor = System.Drawing.Color.Pink
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bernard MT Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Pink
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.RDataGridView.ColumnHeadersHeight = 30
        Me.RDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.RDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EDIT})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LavenderBlush
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.RDataGridView.GridColor = System.Drawing.Color.PaleVioletRed
        Me.RDataGridView.Location = New System.Drawing.Point(14, 110)
        Me.RDataGridView.Name = "RDataGridView"
        Me.RDataGridView.ReadOnly = True
        Me.RDataGridView.RowHeadersVisible = False
        Me.RDataGridView.Size = New System.Drawing.Size(816, 575)
        Me.RDataGridView.TabIndex = 9
        Me.RDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.RDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.RDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.RDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.RDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.RDataGridView.ThemeStyle.BackColor = System.Drawing.Color.Pink
        Me.RDataGridView.ThemeStyle.GridColor = System.Drawing.Color.PaleVioletRed
        Me.RDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.RDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.RDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.RDataGridView.ThemeStyle.HeaderStyle.Height = 30
        Me.RDataGridView.ThemeStyle.ReadOnly = True
        Me.RDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.RDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.RDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RDataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.RDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        'FMR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(842, 658)
        Me.Controls.Add(Me.RDataGridView)
        Me.Controls.Add(Me.Recordcmb)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FMR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.RDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Recordcmb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents RDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents EDIT As DataGridViewImageColumn
End Class
