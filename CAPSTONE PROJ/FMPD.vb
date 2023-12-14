Imports MongoDB.Driver
Imports MongoDB.Bson
Imports System.IO
Public Class FMPD
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
            Collection = database.GetCollection(Of BsonDocument)(collectionName)

            Dim document As New BsonDocument()

            document.Add("Pcode", pcode.Text)
            document.Add("Description", descp.Text)
            document.Add("YearLevel", yearl.Text)

            Collection.InsertOne(document)

            MessageBox.Show("Program detail saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error inserting documents: " & ex.Message, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        With FMP
            .Show()
            Me.Hide()
        End With
    End Sub
End Class