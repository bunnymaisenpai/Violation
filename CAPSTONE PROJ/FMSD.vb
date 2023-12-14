Imports MongoDB.Driver
Imports MongoDB.Bson
Public Class FMSD
    Private database As IMongoDatabase
    Private collectionSE As IMongoCollection(Of BsonDocument)
    Private client As MongoClient
    Private collection As IMongoCollection(Of BsonDocument)

    Public Sub CLEAR()
        studentno.Clear()
        fnametxt.Clear()
        mnametxt.Clear()
        lnametxt.Clear()
        age.Clear()
        gender.Clear()
        progtxt.Clear()
        yltxt.Clear()
        sectxt.Clear()
        addresstxt.Clear()
        gdntxt.Clear()
        rstxt.Clear()
        contacttxt.Clear()
    End Sub
    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        Dim connectionString As String = "mongodb+srv://atlas:atlas@cluster0.sktubmk.mongodb.net/"
        Dim databaseName As String = "DBviolate"
        Dim collectionName As String = "student_entry"

        client = New MongoClient(connectionString)
        database = client.GetDatabase(databaseName)
        collection = database.GetCollection(Of BsonDocument)(collectionName)
        Dim ID As String = studentno.Text
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of Integer)("Student No", ID)
        Dim existingDocument = collection.Find(filter).FirstOrDefault()

        If existingDocument IsNot Nothing Then
            existingDocument.Set("StudentNo", studentno.Text)
            existingDocument.Set("FirstName", fnametxt.Text)
            existingDocument.Set("MiddleName", mnametxt.Text)
            existingDocument.Set("LastName", lnametxt.Text)
            existingDocument.Set("Age", age.Text)
            existingDocument.Set("Gender", gender.Text)
            existingDocument.Set("Program", progtxt.Text)
            existingDocument.Set("YearLevel", yltxt.Text)
            existingDocument.Set("Section", sectxt.Text)
            existingDocument.Set("Address", addresstxt.Text)
            existingDocument.Set("Guardian Name", gdntxt.Text)
            existingDocument.Set("Relation to Student", rstxt.Text)
            existingDocument.Set("Contact Number", contacttxt.Text)

            If MsgBox("Update Student Information?", vbQuestion + vbYesNo) = vbYes Then
                MessageBox.Show("Student Information updated successfully", "Student Information Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                collection.ReplaceOne(filter, existingDocument)
                With FMSL
                    .LoadSDG()
                    Me.Hide()
                End With
            Else
                MessageBox.Show("Student Information update cancelled", "Student Information Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Document with Student No " & ID & " not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        With FMSL
            .Show()
            Me.Hide()
        End With
    End Sub
    Private Sub sbtn_Click(sender As Object, e As EventArgs) Handles sbtn.Click
        Dim connectionString As String = "mongodb+srv://atlas:atlas@cluster0.sktubmk.mongodb.net/"
        Dim databaseName As String = "DBviolate"
        Dim collectionName As String = "student_entry"

        client = New MongoClient(connectionString)
        database = client.GetDatabase(databaseName)
        collection = database.GetCollection(Of BsonDocument)(collectionName)
        Dim ID As String = studentno.Text
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of Integer)("Student No", ID)
        Dim existingDocument = collection.Find(filter).FirstOrDefault()

        If existingDocument IsNot Nothing Then
            existingDocument.Set("StudentNo", studentno.Text)
            existingDocument.Set("FirstName", fnametxt.Text)
            existingDocument.Set("MiddleName", mnametxt.Text)
            existingDocument.Set("LastName", lnametxt.Text)
            existingDocument.Set("Age", age.Text)
            existingDocument.Set("Gender", gender.Text)
            existingDocument.Set("Program", progtxt.Text)
            existingDocument.Set("YearLevel", yltxt.Text)
            existingDocument.Set("Section", sectxt.Text)
            existingDocument.Set("Address", addresstxt.Text)
            existingDocument.Set("Guardian Name", gdntxt.Text)
            existingDocument.Set("Relation to Student", rstxt.Text)
            existingDocument.Set("Contact Number", contacttxt.Text)

            If MsgBox("Save Student Information?", vbQuestion + vbYesNo) = vbYes Then
                MessageBox.Show("Student Information Save successfully!", "Student Entry Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                collection.ReplaceOne(filter, existingDocument)
                With FMVL
                    .LoadVDG()
                    Me.Hide()
                End With
                CLEAR()
            End If
        Else
            MessageBox.Show("Document with Student No " & ID & " not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub FMSD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class