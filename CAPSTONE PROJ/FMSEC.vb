Imports MongoDB.Driver
Imports MongoDB.Bson
Imports System.IO
Public Class FMSEC
    Private client As MongoClient
    Private database As IMongoDatabase
    Private collection As IMongoCollection(Of BsonDocument)

    Public Sub LoadSECDG()
        Try

            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionSEC)

            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()

            SECDataGridView.Rows.Clear()
            For Each document As BsonDocument In documents
                Dim rowData As New List(Of String)()
                rowData.Add(document("Section").ToString())
                rowData.Add(document("Room Description").ToString())
                rowData.Add(document("P code").ToString())

                SECDataGridView.Rows.Add(rowData.ToArray())

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub SECDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SECDataGridView.CellContentClick
        With FMSECE
            .cancelbtn.Show()
            .svbtn.Show()
            .sc.Text = SECDataGridView.Rows(e.RowIndex).Cells(1).Value.ToString
            .rd.Text = SECDataGridView.Rows(e.RowIndex).Cells(2).Value.ToString
            .pcode.Text = SECDataGridView.Rows(e.RowIndex).Cells(3).Value.ToString

            .ShowDialog()
            LoadSECDG()

        End With
    End Sub

    Private Sub FMSEC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "mongodb+srv://atlas:atlas@cluster0.sktubmk.mongodb.net"
        Dim databaseName As String = "DBviolate"
        Dim collectionName As String = "violation_entry"

        client = New MongoClient(connectionString)
        database = client.GetDatabase(databaseName)
        collection = database.GetCollection(Of BsonDocument)(collectionName)

        Guna2ComboBox1.Items.Add("2022-2023 1st Sem")
        Guna2ComboBox1.Items.Add("2022-2023 2nd Sem")
        Guna2ComboBox1.Items.Add("2023-2024 1st Sem")
        Guna2ComboBox1.Items.Add("2023-2024 2nd Sem")

        LoadData()
    End Sub
    Private Async Sub LoadData()
        Try
            Dim filterValue As String = Guna2ComboBox1.SelectedItem?.ToString()

            If Not String.IsNullOrEmpty(filterValue) Then
                Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("Section", filterValue)

                Dim documents = Await collection.Find(filter).ToListAsync()

                Dim dataTable As New DataTable()
                dataTable.Columns.Add("SECTION")
                dataTable.Columns.Add("ROOM DESCRIPTION")
                dataTable.Columns.Add("P CODE")

                For Each document As BsonDocument In documents

                    Dim rowData As New List(Of String)()
                    rowData.Add(document("Section").ToString())
                    rowData.Add(document("Room Description").ToString())
                    rowData.Add(document("P code").ToString())

                    dataTable.Rows.Add(rowData.ToArray())
                Next
                SECDataGridView.DataSource = dataTable
                SECDataGridView.Refresh()
            Else
                SECDataGridView.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        With FMSECE
            .Show()
            Me.Hide()
        End With
    End Sub
End Class