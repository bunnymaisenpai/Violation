Imports MongoDB.Driver
Imports MongoDB.Bson
Imports System.ComponentModel
Imports System.Web.UI.WebControls

Public Class FMSL
    Private client As MongoClient
    Private database As IMongoDatabase
    Private collection As IMongoCollection(Of BsonDocument)
    Private dataTable As DataTable

    Public Sub LoadSDG()
        Try
            Dim connectionString As String = "mongodb+srv://atlas:atlas@cluster0.sktubmk.mongodb.net"
            Dim databaseName As String = "DBviolate"
            Dim collectionName As String = "student_entry"

            Dim client As New MongoClient(connectionString)
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)

            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionName)

            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()
            SLDataGridView.Rows.Clear()

            For Each document As BsonDocument In documents
                Dim rowData As New List(Of String)()
                rowData.Add(document("StudentNo").ToString())
                rowData.Add(document("FirstName").ToString())
                rowData.Add(document("MiddleName").ToString())
                rowData.Add(document("LastName").ToString())
                rowData.Add(document("Age").ToString())
                rowData.Add(document("Gender").ToString())
                rowData.Add(document("Program").ToString())
                rowData.Add(document("Year Level").ToString())
                rowData.Add(document("Section").ToString())
                rowData.Add(document("Address").ToString())
                rowData.Add(document("Guardian Name").ToString())
                rowData.Add(document("Relation to Student").ToString())
                rowData.Add(document("Contact Number").ToString())

                SLDataGridView.Rows.Add(rowData.ToArray())

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub SLDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SLDataGridView.CellContentClick
        With FMSD
            .cancelbtn.Show()
            .updatebtn.Show()

            .studentno.Text = SLDataGridView.Rows(e.RowIndex).Cells(1).Value.ToString
            .fnametxt.Text = SLDataGridView.Rows(e.RowIndex).Cells(2).Value.ToString
            .mnametxt.Text = SLDataGridView.Rows(e.RowIndex).Cells(3).Value.ToString
            .lnametxt.Text = SLDataGridView.Rows(e.RowIndex).Cells(4).Value.ToString
            .age.Text = SLDataGridView.Rows(e.RowIndex).Cells(5).Value.ToString
            .gender.Text = SLDataGridView.Rows(e.RowIndex).Cells(6).Value.ToString
            .progtxt.Text = SLDataGridView.Rows(e.RowIndex).Cells(7).Value.ToString
            .yltxt.Text = SLDataGridView.Rows(e.RowIndex).Cells(8).Value.ToString
            .sectxt.Text = SLDataGridView.Rows(e.RowIndex).Cells(9).Value.ToString
            .addresstxt.Text = SLDataGridView.Rows(e.RowIndex).Cells(10).Value.ToString
            .gdntxt.Text = SLDataGridView.Rows(e.RowIndex).Cells(11).Value.ToString
            .rstxt.Text = SLDataGridView.Rows(e.RowIndex).Cells(12).Value.ToString
            .contacttxt.Text = SLDataGridView.Rows(e.RowIndex).Cells(13).Value.ToString
            .ShowDialog()
            LoadSDG()

        End With
    End Sub

    Private Sub FMSL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim connectionString As String = "mongodb+srv://atlas:atlas@cluster0.sktubmk.mongodb.net"
            Dim databaseName As String = "DBviolate"
            Dim collectionName As String = "student_entry"

            Dim client As New MongoClient(connectionString)
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)

            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionName)


            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()

            Dim dataTable As New DataTable()
            dataTable.Columns.Add("STUDENTNO")
            dataTable.Columns.Add("FIRST")
            dataTable.Columns.Add("MIDDLE")
            dataTable.Columns.Add("LAST")
            dataTable.Columns.Add("AGE")
            dataTable.Columns.Add("GENDER")
            dataTable.Columns.Add("PROG")
            dataTable.Columns.Add("YL")
            dataTable.Columns.Add("SECTION")
            dataTable.Columns.Add("ADDRESS")
            dataTable.Columns.Add("GUARDIAN")
            dataTable.Columns.Add("RELATION")
            dataTable.Columns.Add("CONTACT")


            For Each document As BsonDocument In documents
                Dim rowData As New List(Of String)()
                rowData.Add(document("StudentNo").ToString())
                rowData.Add(document("FirstName").ToString())
                rowData.Add(document("MiddleName").ToString())
                rowData.Add(document("LastName").ToString())
                rowData.Add(document("Age").ToString())
                rowData.Add(document("Gender").ToString())
                rowData.Add(document("Program").ToString())
                rowData.Add(document("Year Level").ToString())
                rowData.Add(document("Section").ToString())
                rowData.Add(document("Address").ToString())
                rowData.Add(document("Guardian Name").ToString())
                rowData.Add(document("Relation to Student").ToString())
                rowData.Add(document("Contact Number").ToString())
                dataTable.Rows.Add(rowData.ToArray())
            Next
            SLDataGridView.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        With FMSE
            .Show()
            Me.Hide()
        End With
    End Sub

    Private Sub Guna2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox1.KeyPress
        Dim searchText As String = Guna2TextBox1.Text.Trim()
        Dim searchTerms() As String = searchText.Split(" "c)
        Dim filterExpression As String = ""

        For Each term In searchTerms
            If Not String.IsNullOrWhiteSpace(term) Then
                filterExpression &= String.Format("LAST like '%{0}%' OR FIRST like '%{0}%' OR " &
                                                  "MIDDLE like '%{0}%' OR STUDENTNO like '%{0}%' OR " &
                                                  "AGE like '%{0}%' OR GENDER like '%{0}%' OR " &
                                                  "PROG like '%{0}%' OR YL like '%{0}%' OR " &
                                                  "SECTION like '%{0}%' OR ", term)
            End If
        Next
        If Not String.IsNullOrWhiteSpace(filterExpression) Then
            filterExpression = filterExpression.Substring(0, filterExpression.Length - 4)
        End If
        TryCast(SLDataGridView.DataSource, DataTable).DefaultView.RowFilter = filterExpression
    End Sub

End Class
