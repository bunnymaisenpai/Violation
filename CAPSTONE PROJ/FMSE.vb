Imports MongoDB.Driver
Imports MongoDB.Bson
Imports System.IO
Public Class FMSE
    Private client As MongoClient
    Private database As IMongoDatabase
    Private collection As IMongoCollection(Of BsonDocument)
    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        Try
            Dim connectionString As String = "mongodb+srv://atlas:atlas@cluster0.sktubmk.mongodb.net/"
            Dim databaseName As String = "DBviolate"
            Dim collectionName As String = "student_entry"

            client = New MongoClient(connectionString)
            database = client.GetDatabase(databaseName)
            collection = database.GetCollection(Of BsonDocument)(collectionName)

            Dim Studentnumber As String = studentno.Text
            Dim First As String = fname.Text
            Dim middle As String = mname.Text
            Dim last As String = lname.Text
            Dim agee As String = age.Text
            Dim gender As String = gendercmb.Text
            Dim program As String = progcmb.Text
            Dim yearlevel As String = ylcmb.Text
            Dim section As String = seccmb.Text
            Dim addresss As String = address.Text
            Dim guardian As String = guadiann.Text
            Dim relation As String = rs.Text
            Dim contactt As String = contact.Text

            Dim document As New BsonDocument()

            document.Add("StudentNo", Studentnumber)
            document.Add("FirstName", First)
            document.Add("MiddleName", middle)
            document.Add("LastName", last)
            document.Add("Age", agee)
            document.Add("Gender", gender)
            document.Add("Program", program)
            document.Add("Year Level", yearlevel)
            document.Add("Section", section)
            document.Add("Address", addresss)
            document.Add("Guardian Name", guardian)
            document.Add("Relation to Student", relation)
            document.Add("Contact Number", contactt)


            Dim imageBytes As Byte()
            Using stream As New MemoryStream()
                img.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                imageBytes = stream.ToArray()
            End Using

            Dim base64String As String = Convert.ToBase64String(imageBytes)
            document.Add("StudentImage", base64String)

            Dim filter = Builders(Of BsonDocument).Filter.Eq(Of Integer)("Student No", Studentnumber)
            Dim existingDocument = collection.Find(filter).FirstOrDefault()

            If existingDocument IsNot Nothing Then
                MessageBox.Show("Student ID already exists.", "Duplicate Student ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            Else
                collection.InsertOne(document)
                MessageBox.Show("Student Information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error inserting documents: " & ex.Message, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub stlv_Click(sender As Object, e As EventArgs) Handles stlv.Click
        With FMSL
            .Show()
            Me.Hide()
        End With
    End Sub

    Private Sub CLR1_Click(sender As Object, e As EventArgs) Handles CLR1.Click
        studentno.Clear()
        fname.Clear()
        mname.Clear()
        lname.Clear()
        age.Clear()
        gendercmb.Items.Clear()
        gendercmb.SelectedIndex = -1
        progcmb.Items.Clear()
        progcmb.SelectedIndex = -1
        ylcmb.Items.Clear()
        ylcmb.SelectedIndex = -1
        seccmb.Items.Clear()
        seccmb.SelectedIndex = -1
        address.Clear()
        guadiann.Clear()
        rs.Clear()
        contact.Clear()


        img.Image = Nothing
        ' Or use the following equivalent statement:
        ' PictureBox1.Image = New Bitmap(1, 1)
    End Sub

    Private Sub addbtn_Click_1(sender As Object, e As EventArgs) Handles addbtn.Click
        Dim arrImage() As Byte
        Dim imgpath As String
        Dim opf As FileDialog = New OpenFileDialog
        opf.Filter = "Choose Your Profile Picture (.jpg;.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*jpeg"
        If opf.ShowDialog() = DialogResult.OK Then
            imgpath = opf.FileName
            img.SizeMode = PictureBoxSizeMode.StretchImage
            img.ImageLocation = imgpath
        End If
        opf = Nothing
    End Sub

    Private Sub FMSE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class