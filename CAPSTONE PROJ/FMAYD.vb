Imports MongoDB.Driver
Imports MongoDB.Bson
Imports System.IO
Public Class FMAYD
    Private client As MongoClient
    Private database As IMongoDatabase
    Private collection As IMongoCollection(Of BsonDocument)
    Private Sub svbtn_Click(sender As Object, e As EventArgs) Handles svbtn.Click
        Try
            Dim connectionString As String = "mongodb+srv://atlas:atlas@cluster0.sktubmk.mongodb.net/"
            Dim databaseName As String = "DBviolate"
            Dim collectionName As String = "student_entry"

            client = New MongoClient(connectionString)
            database = client.GetDatabase(databaseName)
            collection = database.GetCollection(Of BsonDocument)(collectionName)

            Dim document As New BsonDocument()

            document.Add("AYcode", acode.Text)
            document.Add("Year From", yf.Text)
            document.Add("Year To", yt.Text)
            document.Add("Semester", sem.Text)
            document.Add("Status", statcmb.Text)

            Collection.InsertOne(document)

            MessageBox.Show("Academic Year Entry saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error inserting documents: " & ex.Message, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        With FMAY
            .Show()
            Me.Hide()
        End With
    End Sub
End Class