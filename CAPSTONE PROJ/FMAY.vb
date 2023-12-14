Imports MongoDB.Bson
Imports MongoDB.Driver
Imports System.IO
Public Class FMAY
    Private client As MongoClient
    Private database As IMongoDatabase
    Private collection As IMongoCollection(Of BsonDocument)
    Public Sub LoadAYDG()
        Try

            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionAY)

            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()

            AYDataGridView.Rows.Clear()
            For Each document As BsonDocument In documents
                Dim rowData As New List(Of String)()
                rowData.Add(document("AY code").ToString())
                rowData.Add(document("Year From").ToString())
                rowData.Add(document("Year To").ToString())
                rowData.Add(document("Semester").ToString())
                rowData.Add(document("Status").ToString())

                AYDataGridView.Rows.Add(rowData.ToArray())

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub AYDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AYDataGridView.CellContentClick
        With FMAYD
            .cancelbtn.Show()
            .svbtn.Show()
            .acode.Text = AYDataGridView.Rows(e.RowIndex).Cells(1).Value.ToString
            .yf.Text = AYDataGridView.Rows(e.RowIndex).Cells(2).Value.ToString
            .yt.Text = AYDataGridView.Rows(e.RowIndex).Cells(3).Value.ToString
            .sem.Text = AYDataGridView.Rows(e.RowIndex).Cells(4).Value.ToString
            .statcmb.Text = AYDataGridView.Rows(e.RowIndex).Cells(5).Value.ToString
            .ShowDialog()
            LoadAYDG()

        End With
    End Sub

    Private Sub FMAY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "mongodb+srv://atlas:atlas@cluster0.sktubmk.mongodb.net"
        Dim databaseName As String = "DBviolate"
        Dim collectionName As String = "violation_entry"

        client = New MongoClient(connectionString)
        database = client.GetDatabase(databaseName)
        collection = database.GetCollection(Of BsonDocument)(collectionName)

        Guna2ComboBox1.Items.Add("2022-2023")
        Guna2ComboBox1.Items.Add("2022-2023")
        Guna2ComboBox1.Items.Add("2023-2024")
        Guna2ComboBox1.Items.Add("2023-2024")

        LoadData()
    End Sub
    Private Async Sub LoadData()
        Try
            Dim filterValue As String = Guna2ComboBox1.SelectedItem?.ToString()

            If Not String.IsNullOrEmpty(filterValue) Then
                Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("AYcode", filterValue)

                Dim documents = Await collection.Find(filter).ToListAsync()

                Dim dataTable As New DataTable()
                dataTable.Columns.Add("AY code")
                dataTable.Columns.Add("Year From")
                dataTable.Columns.Add("Year To")
                dataTable.Columns.Add("Semester")
                dataTable.Columns.Add("Status")
                For Each document As BsonDocument In documents

                    Dim rowData As New List(Of String)()
                    rowData.Add(document("AYcode").ToString())
                    rowData.Add(document("Year From").ToString())
                    rowData.Add(document("Year To").ToString())
                    rowData.Add(document("Semester").ToString())
                    rowData.Add(document("Status").ToString())

                    dataTable.Rows.Add(rowData.ToArray())
                Next
                AYDataGridView.DataSource = dataTable
                AYDataGridView.Refresh()
            Else
                AYDataGridView.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        With FMAYD
            .Show()
            Me.Hide()
        End With
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        LoadData()
    End Sub
End Class