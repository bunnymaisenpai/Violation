Imports MongoDB.Driver
Imports MongoDB.Bson
Imports System.IO
Public Class FMSECE
    Private client As MongoClient
    Private database As IMongoDatabase
    Private collection As IMongoCollection(Of BsonDocument)
    Private Sub svbtn_Click(sender As Object, e As EventArgs) Handles svbtn.Click
        Try
            Dim connectionString As String = "mongodb+srv://atlas:atlas@cluster0.sktubmk.mongodb.net/"
            Dim databaseName As String = "DBviolate"
            Dim collectionName As String = "program"

            client = New MongoClient(connectionString)
            database = client.GetDatabase(databaseName)
            collection = database.GetCollection(Of BsonDocument)(collectionName)

            Dim document As New BsonDocument()

            document.Add("Section", sc.Text)
            document.Add("Room Description", rd.Text)
            document.Add("P code", pcode.Text)

            Collection.InsertOne(document)

            MessageBox.Show("Section Entry saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error inserting documents: " & ex.Message, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        With FMSEC
            .Show()
            Me.Hide()
        End With
    End Sub
End Class