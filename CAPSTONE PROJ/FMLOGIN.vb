Imports MongoDB.Driver
Public Class FMLOGIN
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        If user.Text = "admin" And pass.Text = "admin1" Then
            MessageBox.Show("Access Granted", "WELCOME!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            FMMAIN.Show()

        ElseIf String.IsNullOrWhiteSpace(user.Text) AndAlso String.IsNullOrWhiteSpace(pass.Text) Then
            MessageBox.Show("Please enter your Username and Password!")
        ElseIf String.IsNullOrWhiteSpace(user.Text) Then
            MessageBox.Show("Please enter your Username!")
        ElseIf String.IsNullOrWhiteSpace(pass.Text) Then
            MessageBox.Show("Please enter your Password!")
        End If
    End Sub

    Private Sub FMLOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim client As MongoClient = New MongoClient(connectionString)
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)


            MessageBox.Show($"You are connected to the {databaseName} MongoDB database.", "Connection Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

            MessageBox.Show($"Error connecting to the MongoDB database: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pass_TextChanged(sender As Object, e As EventArgs) Handles pass.TextChanged

    End Sub

    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel1.Paint

    End Sub
End Class
