Imports MongoDB.Driver
Imports MongoDB.Bson
Imports System.IO
Imports Amazon.Runtime

Public Class FMP
    Private client As MongoClient
    Private database As IMongoDatabase
    Private collection As IMongoCollection(Of BsonDocument)

    Public Sub LoadPDG()
        Try

            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionP)

            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()

            PDataGridView.Rows.Clear()
            For Each document As BsonDocument In documents
                Dim rowData As New List(Of String)()
                rowData.Add(document("P code").ToString())
                rowData.Add(document("Description").ToString())
                rowData.Add(document("Year Level").ToString())

                PDataGridView.Rows.Add(rowData.ToArray())

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub PDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PDataGridView.CellContentClick
        With FMPD
            .cancelbtn.Show()
            .svbtn.Show()
            .pcode.Text = PDataGridView.Rows(e.RowIndex).Cells(1).Value.ToString
            .descp.Text = PDataGridView.Rows(e.RowIndex).Cells(2).Value.ToString
            .yearl.Text = PDataGridView.Rows(e.RowIndex).Cells(3).Value.ToString


            .ShowDialog()
            LoadPDG()

        End With
    End Sub

    Private Sub FMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "mongodb+srv://atlas:atlas@cluster0.sktubmk.mongodb.net"
        Dim databaseName As String = "DBviolate"
        Dim collectionName As String = "program"

        client = New MongoClient(connectionString)
        database = client.GetDatabase(databaseName)
        collection = database.GetCollection(Of BsonDocument)(collectionName)

        Guna2ComboBox1.Items.Add("GAS")
        Guna2ComboBox1.Items.Add("STEM")
        Guna2ComboBox1.Items.Add("TVL")
        Guna2ComboBox1.Items.Add("HUMSS")

        LoadData()
    End Sub
    Private Async Sub LoadData()
        Try
            Dim filterValue As String = Guna2ComboBox1.SelectedItem?.ToString()

            If Not String.IsNullOrEmpty(filterValue) Then
                Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("Pcode", filterValue)
                Dim documents = Await collection.Find(filter).ToListAsync()


                Dim dataTable As New DataTable()
                dataTable.Columns.Add("P CODE")
                dataTable.Columns.Add("DESCRIPTION")
                dataTable.Columns.Add("YEAR LEVEL")

                For Each document As BsonDocument In Documents
                    Dim rowData As New List(Of String)()
                    rowData.Add(document("Pcode").ToString())
                    rowData.Add(document("Description").ToString())
                    rowData.Add(document("YearLevel").ToString())
                    dataTable.Rows.Add(rowData.ToArray())
                Next
                PDataGridView.DataSource = dataTable
                PDataGridView.Refresh()
            Else
                PDataGridView.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        With FMPD
            .Show()
            Me.Hide()
        End With
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        LoadData()
    End Sub
End Class