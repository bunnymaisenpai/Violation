Imports MongoDB.Driver
Imports MongoDB.Bson
Public Class FMIRL
    Private client As MongoClient
    Private database As IMongoDatabase
    Private collection As IMongoCollection(Of BsonDocument)
    Private dataTable As DataTable
    Public Sub LoadIRDG()
        Try

            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionVE)

            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()

            IRDataGridView.Rows.Clear()
            For Each document As BsonDocument In documents
                Dim rowData As New List(Of String)()
                rowData.Add(document("qrscan").ToString())

                IRDataGridView.Rows.Add(rowData.ToArray())

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub FMIRL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim connectionString As String = "mongodb+srv://atlas:atlas@cluster0.sktubmk.mongodb.net"
            Dim databaseName As String = "DBviolate"
            Dim collectionName As String = "incident_report"

            Dim client As New MongoClient(connectionString)
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)

            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionIR)


            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()

            Dim dataTable As New DataTable()
            dataTable.Columns.Add("QR SCAN")
            For Each document As BsonDocument In documents
                Dim rowData As New List(Of String)()
                rowData.Add(document("qrscan").ToString())
                dataTable.Rows.Add(rowData.ToArray())
            Next
            IRDataGridView.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bckbtn_Click(sender As Object, e As EventArgs) Handles bckbtn.Click
        With FMINCIDENT
            .Show()
            Me.Hide()
        End With
    End Sub
End Class