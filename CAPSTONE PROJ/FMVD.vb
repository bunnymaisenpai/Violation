Imports MongoDB.Driver
Imports MongoDB.Bson
Public Class FMVD
    Private database As IMongoDatabase
    Private collectionVE As IMongoCollection(Of BsonDocument)
    Private client As MongoClient
    Private collection As IMongoCollection(Of BsonDocument)

    Public Sub CLEAR()
        studentno.Clear()
        fntxt.Clear()
        parent.Clear()
        ptxt.Clear()
        stxt.Clear()
        yl.Clear()
        ay.Clear()
        vtxt.Clear()
        sanc.Clear()
        type.Clear()
    End Sub
    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        Dim connectionString As String = "mongodb+srv://atlas:atlas@cluster0.sktubmk.mongodb.net/"
        Dim databaseName As String = "DBviolate"
        Dim collectionName As String = "violation_entry"

        client = New MongoClient(connectionString)
        database = client.GetDatabase(databaseName)
        collection = database.GetCollection(Of BsonDocument)(collectionName)
        Dim ID As String = studentno.Text
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of Integer)("Student No", ID)
        Dim existingDocument = collection.Find(filter).FirstOrDefault()

        If existingDocument IsNot Nothing Then
            existingDocument("Student No") = studentno.Text
            existingDocument("Name") = fntxt.Text
            existingDocument("Guardian No.") = parent.Text
            existingDocument("Program") = ptxt.Text
            existingDocument("Section") = stxt.Text
            existingDocument("YearLevel") = yl.Text
            existingDocument("AYcode") = ay.Text
            existingDocument("Violation") = vtxt.Text
            existingDocument("Sanction") = sanc.Text
            existingDocument("Type") = type.Text

            If MsgBox("Update Violation Information?", vbQuestion + vbYesNo) = vbYes Then
                MessageBox.Show("Violation Information updated successfully", "Violation Entry Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                collection.ReplaceOne(filter, existingDocument)
                With FMVL
                    .LoadVDG()
                    Me.Hide()
                End With
            Else
                MessageBox.Show("Violation Information update cancelled", "Violation Information Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Document with Student No " & ID & " not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Me.Hide()
        CLEAR()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles svebtn.Click
        Dim connectionString As String = "mongodb+srv://atlas:atlas@cluster0.sktubmk.mongodb.net/"
        Dim databaseName As String = "DBviolate"
        Dim collectionName As String = "violation_entry"

        client = New MongoClient(connectionString)
        database = client.GetDatabase(databaseName)
        collection = database.GetCollection(Of BsonDocument)(collectionName)
        Dim ID As String = studentno.Text
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of Integer)("Student No", ID)
        Dim existingDocument = collection.Find(filter).FirstOrDefault()

        If existingDocument IsNot Nothing Then
            existingDocument("Student No") = studentno.Text
            existingDocument("Name") = fntxt.Text
            existingDocument("Guardian No.") = parent.Text
            existingDocument("Program") = ptxt.Text
            existingDocument("Section") = stxt.Text
            existingDocument("YearLevel") = yl.Text
            existingDocument("AYcode") = ay.Text
            existingDocument("Violation") = vtxt.Text
            existingDocument("Sanction") = sanc.Text
            existingDocument("Type") = type.Text

            If MsgBox("Do you want to save Violation Information?", vbQuestion + vbYesNo) = vbYes Then
                MessageBox.Show("Violation Information Save successfully!", "Violation Entry Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                collection.ReplaceOne(filter, existingDocument)
                With FMVL
                    .LoadVDG()
                    Me.Hide()
                End With
            Else
                MessageBox.Show("Violation Information save cancelled", "Violation Information Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Document with Student No " & ID & " not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class