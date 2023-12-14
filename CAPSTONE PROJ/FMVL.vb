Imports Guna.UI2.WinForms
Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class FMVL
    Private client As MongoClient
    Private database As IMongoDatabase
    Private collection As IMongoCollection(Of BsonDocument)
    Private dataTable As DataTable

    Public Sub LoadVDG()
        Try
            Dim connectionString As String = "mongodb+srv://atlas:atlas@cluster0.sktubmk.mongodb.net"
            Dim databaseName As String = "DBviolate"
            Dim collectionName As String = "violation_entry"

            Dim client As New MongoClient(connectionString)
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)

            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionName)

            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()

            VLDataGridView.Rows.Clear()
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
                VLDataGridView.Rows.Add(rowData.ToArray())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub FMVL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                rowData.Add(document("AY code").ToString())
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
            VLDataGridView.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub VLDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VLDataGridView.CellContentClick
        Dim colName As String = VLDataGridView.Columns(e.ColumnIndex).Name
        With FMVD
            .cancelbtn.Show()
            .svebtn.Show()
            .updatebtn.Show()
            .ay.Text = VLDataGridView.Rows(e.RowIndex).Cells(1).Value.ToString
            .studentno.Text = VLDataGridView.Rows(e.RowIndex).Cells(2).Value.ToString
            .fntxt.Text = VLDataGridView.Rows(e.RowIndex).Cells(3).Value.ToString
            .stxt.Text = VLDataGridView.Rows(e.RowIndex).Cells(4).Value.ToString
            .ptxt.Text = VLDataGridView.Rows(e.RowIndex).Cells(5).Value.ToString
            .yl.Text = VLDataGridView.Rows(e.RowIndex).Cells(6).Value.ToString
            .parent.Text = VLDataGridView.Rows(e.RowIndex).Cells(7).Value.ToString
            .contact.Text = VLDataGridView.Rows(e.RowIndex).Cells(8).Value.ToString
            .type.Text = VLDataGridView.Rows(e.RowIndex).Cells(9).Value.ToString
            .vtxt.Text = VLDataGridView.Rows(e.RowIndex).Cells(10).Value.ToString
            .others.Text = VLDataGridView.Rows(e.RowIndex).Cells(11).Value.ToString
            .sanc.Text = VLDataGridView.Rows(e.RowIndex).Cells(12).Value.ToString

            .ShowDialog()
            Me.Hide()
            LoadVDG()


        End With
    End Sub

    Private Sub bckbtn_Click(sender As Object, e As EventArgs) Handles bckbtn.Click
        With FMVE
            .Show()
            Me.Hide()
        End With
    End Sub

    Private Sub vlcmb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles vlcmb.KeyPress
        Dim searchText As String = vlcmb.Text.Trim()

        Dim searchTerms() As String = searchText.Split(" "c)

        Dim filterExpression As String = ""

        For Each term In searchTerms
            If Not String.IsNullOrWhiteSpace(term) Then
                filterExpression &= String.Format("A.Ycode like '%{0}%' OR StudentNo like '%{0}%' OR " &
                                              "Name like '%{0}%' OR Section like '%{0}%' OR " &
                                              "Program like '%{0}%' OR YearLevel like '%{0}%' OR " &
                                              "Sanction like '%{0}%' OR Type like '%{0}%' OR " &
                                              "Violation like '%{0}%' OR ", term)
            End If
        Next

        If Not String.IsNullOrWhiteSpace(filterExpression) Then
            filterExpression = filterExpression.Substring(0, filterExpression.Length - 4)
        End If

        TryCast(VLDataGridView.DataSource, DataTable).DefaultView.RowFilter = filterExpression
    End Sub

End Class