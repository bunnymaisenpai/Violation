Imports MongoDB.Driver
Imports MongoDB.Bson
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Amazon.Runtime.Documents
Imports MongoDB.Bson.Serialization

Public Class FMR
    Private client As MongoClient
    Private database As IMongoDatabase
    Private collection As IMongoCollection(Of BsonDocument)
    Public Sub LoadVDG()
        Try
            Dim connectionString As String = "mongodb+srv://atlas:atlas@cluster0.sktubmk.mongodb.net"
            Dim databaseName As String = "DBviolate"
            Dim collectionName As String = "violation_entry"

            Dim client As New MongoClient(connectionString)
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)

            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionName)
            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()

            Dim dataTable As New DataTable()
            dataTable.Columns.Add("A.Ycode")
            dataTable.Columns.Add("StudentNo")
            dataTable.Columns.Add("Name")
            dataTable.Columns.Add("Section")
            dataTable.Columns.Add("Program")
            dataTable.Columns.Add("YearLevel")
            dataTable.Columns.Add("Parents")
            dataTable.Columns.Add("Contact")
            dataTable.Columns.Add("Type")
            dataTable.Columns.Add("Violation")
            dataTable.Columns.Add("Others")
            dataTable.Columns.Add("Sanction")

            For Each document As BsonDocument In documents
                Dim rowData As New List(Of String)()
                rowData.Add(document("A.Y code").ToString())
                rowData.Add(document("Student No").ToString())
                rowData.Add(document("Name").ToString())
                rowData.Add(document("Section").ToString())
                rowData.Add(document("Program").ToString())
                rowData.Add(document("YearLevel").ToString())
                rowData.Add(document("Parents").ToString())
                rowData.Add(document("Contact").ToString())
                rowData.Add(document("Type").ToString())
                rowData.Add(document("Violation").ToString())
                rowData.Add(document("Others").ToString())
                rowData.Add(document("Sanction").ToString())
                dataTable.Rows.Add(rowData.ToArray())

            Next
            RDataGridView.Rows.Clear()
            LoadVDGSORT()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub LoadVDGSORT()
        Try
            Dim connectionString As String = "mongodb+srv://atlas:atlas@cluster0.sktubmk.mongodb.net"
            Dim databaseName As String = "DBviolate"
            Dim collectionName As String = "violation_entry"
            Dim client As New MongoClient(connectionString)
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)

            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)("collectionVE")
            Dim filter = Builders(Of BsonDocument).Filter.Regex("Violation", New BsonRegularExpression(Recordcmb.Text))
            Dim documents As List(Of BsonDocument) = collection.Find(filter).ToList()


            For Each document As BsonDocument In documents
                Dim rowData As New List(Of String)()
                rowData.Add(document("A.Y code").ToString())
                rowData.Add(document("Student No").ToString())
                rowData.Add(document("Name ").ToString())
                rowData.Add(document("Section").ToString())
                rowData.Add(document("Program").ToString())
                rowData.Add(document("YearLevel").ToString())
                rowData.Add(document("Parents").ToString())
                rowData.Add(document("Contact").ToString())
                rowData.Add(document("Type").ToString())
                rowData.Add(document("Violation").ToString())
                rowData.Add(document("Others").ToString())
                rowData.Add(document("Sanction").ToString())
                RDataGridView.Rows.Add(rowData.ToArray())

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Recordcmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Recordcmb.SelectedIndexChanged
        LoadData()
    End Sub

    Private Sub FMR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "mongodb+srv://atlas:atlas@cluster0.sktubmk.mongodb.net"
        Dim databaseName As String = "DBviolate"
        Dim collectionName As String = "violation_entry"

        client = New MongoClient(connectionString)
        database = client.GetDatabase(databaseName)
        collection = database.GetCollection(Of BsonDocument)(collectionName)

        Recordcmb.Items.Add("2022-2023 1st Sem")
        Recordcmb.Items.Add("2022-2023 2nd Sem")
        Recordcmb.Items.Add("2023-2024 1st Sem")
        Recordcmb.Items.Add("2023-2024 2nd Sem")

        LoadData()
    End Sub

    Private Async Sub LoadData()
        Try
            Dim filterValue As String = Recordcmb.SelectedItem?.ToString()

            If Not String.IsNullOrEmpty(filterValue) Then
                Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("AYcode", filterValue)

                Dim documents = Await collection.Find(filter).ToListAsync()

                Dim dataTable As New DataTable()
                dataTable.Columns.Add("A.Ycode")
                dataTable.Columns.Add("StudentNo")
                dataTable.Columns.Add("Name")
                dataTable.Columns.Add("Section")
                dataTable.Columns.Add("Program")
                dataTable.Columns.Add("YearLevel")
                dataTable.Columns.Add("Parents")
                dataTable.Columns.Add("Contact")
                dataTable.Columns.Add("Type")
                dataTable.Columns.Add("Violation")
                dataTable.Columns.Add("Others")
                dataTable.Columns.Add("Sanction")
                ' Add more columns as needed

                For Each document As BsonDocument In documents
                    Dim rowData As New List(Of String)()
                    rowData.Add(document("AYcode")?.ToString())
                    rowData.Add(document("StudentNo")?.ToString())
                    rowData.Add(document("Name")?.ToString())
                    rowData.Add(document("Section")?.ToString())
                    rowData.Add(document("Program")?.ToString())
                    rowData.Add(document("YearLevel")?.ToString())
                    rowData.Add(document("Parents")?.ToString())
                    rowData.Add(document("Contact")?.ToString())
                    rowData.Add(document("Type")?.ToString())
                    rowData.Add(document("Violation")?.ToString())
                    rowData.Add(document("Others")?.ToString())
                    rowData.Add(document("Sanction")?.ToString())
                    dataTable.Rows.Add(rowData.ToArray())
                Next

                RDataGridView.DataSource = dataTable

                RDataGridView.Refresh()
            Else
                RDataGridView.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class



