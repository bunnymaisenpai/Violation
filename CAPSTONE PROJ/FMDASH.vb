Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class FMDASH
    Private client As MongoClient
    Private database As IMongoDatabase
    Public Sub LoadYDG()
        Try


            Dim connectionString As String = "mongodb+srv://atlas:atlas@cluster0.sktubmk.mongodb.net/?retryWrites=true&w=majority"
            Dim databaseName As String = "DBviolate"
            Dim collectionName As String = "academic_year"

            Dim client As New MongoClient(connectionString)
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)

            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionAY)


            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()

            Label5.Text = documents.Count
            For Each document As BsonDocument In documents
                Dim rowData As New List(Of String)()
                rowData.Add(document("AYcode").ToString())
                rowData.Add(document("Year From").ToString())
                rowData.Add(document("Year To").ToString())
                rowData.Add(document("Semester").ToString())
                rowData.Add(document("Status").ToString())


            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub LoadSDG()
        Try


            Dim connectionString As String = "mongodb+srv://atlas:atlas@cluster0.sktubmk.mongodb.net/?retryWrites=true&w=majority"
            Dim databaseName As String = "DBviolate"
            Dim collectionName As String = "student_entry"

            Dim client As New MongoClient(connectionString)
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)

            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionSE)
            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()

            label6.Text = documents.Count
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


            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub LoadVDG()
        Try

            Dim connectionString As String = "mongodb+srv://atlas:atlas@cluster0.sktubmk.mongodb.net/?retryWrites=true&w=majority"
            Dim databaseName As String = "DBviolate"
            Dim collectionName As String = "violation_entry"

            Dim client As New MongoClient(connectionString)
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)

            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionVE)
            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()

            Label7.Text = documents.Count


            For Each document As BsonDocument In documents
                Dim rowData As New List(Of String)()
                rowData.Add(document("AYcode").ToString())
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

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FMDASH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadYDG()
        LoadSDG()
        LoadVDG()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class