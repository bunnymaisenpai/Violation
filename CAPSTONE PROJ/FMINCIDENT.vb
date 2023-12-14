Imports MongoDB.Driver
Imports MongoDB.Bson
Public Class FMINCIDENT
    Private client As MongoClient
    Private database As IMongoDatabase
    Private collection As IMongoCollection(Of BsonDocument)
    Private dataTable As DataTable

    Private Sub scan_Click(sender As Object, e As EventArgs) Handles scan.Click
        With FMQR
            .Show()
            Me.Hide()
        End With
    End Sub

    Private Sub irlv_Click(sender As Object, e As EventArgs) Handles irlv.Click
        With FMIRL
            .Show()
            Me.Hide()
        End With

    End Sub

    Private Sub FMINCIDENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadincident()
    End Sub

    Public Sub Loadincident()
        Try

            Dim connectionString As String = "mongodb+srv://atlas:atlas@cluster0.sktubmk.mongodb.net/?retryWrites=true&w=majority"
            Dim databaseName As String = "DBviolate"
            Dim collectionName As String = "incident_report"

            Dim client As New MongoClient(connectionString)
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)

            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionVE)
            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()

            Label10.Text = documents.Count
            Label5.Text = documents.Count


            For Each document As BsonDocument In documents
                Dim rowData As New List(Of String)()
                rowData.Add(document("qrscan").ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class