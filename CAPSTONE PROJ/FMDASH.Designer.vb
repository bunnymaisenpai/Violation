<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FMDASH
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tv = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Ts = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AY = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        Me.tv.SuspendLayout()
        Me.Ts.SuspendLayout()
        Me.AY.SuspendLayout()
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
        Me.Guna2Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(271, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DASHBOARD"
        '
        'tv
        '
        Me.tv.Controls.Add(Me.Label7)
        Me.tv.Controls.Add(Me.Label4)
        Me.tv.CustomBorderColor = System.Drawing.Color.Black
        Me.tv.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.tv.FillColor = System.Drawing.Color.SkyBlue
        Me.tv.FillColor2 = System.Drawing.Color.Lavender
        Me.tv.Location = New System.Drawing.Point(559, 157)
        Me.tv.Name = "tv"
        Me.tv.Size = New System.Drawing.Size(189, 134)
        Me.tv.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("MingLiU-ExtB", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(141, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 35)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total Violation"
        '
        'Ts
        '
        Me.Ts.Controls.Add(Me.label6)
        Me.Ts.Controls.Add(Me.Label3)
        Me.Ts.CustomBorderColor = System.Drawing.Color.Black
        Me.Ts.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.Ts.FillColor = System.Drawing.Color.Violet
        Me.Ts.FillColor2 = System.Drawing.Color.LavenderBlush
        Me.Ts.Location = New System.Drawing.Point(301, 157)
        Me.Ts.Name = "Ts"
        Me.Ts.Size = New System.Drawing.Size(189, 134)
        Me.Ts.TabIndex = 5
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Font = New System.Drawing.Font("MingLiU-ExtB", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(152, 80)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(34, 35)
        Me.label6.TabIndex = 2
        Me.label6.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bernard MT Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total Students"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AY
        '
        Me.AY.Controls.Add(Me.Label5)
        Me.AY.Controls.Add(Me.Label2)
        Me.AY.CustomBorderColor = System.Drawing.Color.Black
        Me.AY.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.AY.FillColor = System.Drawing.Color.HotPink
        Me.AY.FillColor2 = System.Drawing.Color.LavenderBlush
        Me.AY.Location = New System.Drawing.Point(45, 157)
        Me.AY.Name = "AY"
        Me.AY.Size = New System.Drawing.Size(189, 134)
        Me.AY.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("MingLiU-ExtB", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(139, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 35)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 50)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Academic Year / " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Semester"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FMDASH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(842, 697)
        Me.Controls.Add(Me.tv)
        Me.Controls.Add(Me.Ts)
        Me.Controls.Add(Me.AY)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FMDASH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FMDASH"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.tv.ResumeLayout(False)
        Me.tv.PerformLayout()
        Me.Ts.ResumeLayout(False)
        Me.Ts.PerformLayout()
        Me.AY.ResumeLayout(False)
        Me.AY.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents tv As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Ts As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents AY As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents label6 As Label
End Class
