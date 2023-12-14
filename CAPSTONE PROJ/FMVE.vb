Imports MongoDB.Driver
Imports MongoDB.Bson
Imports System.IO

Public Class FMVE
    Private client As MongoClient
    Private database As IMongoDatabase
    Private collection As IMongoCollection(Of BsonDocument)
    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        Try
            Dim connectionString As String = "mongodb+srv://atlas:atlas@cluster0.sktubmk.mongodb.net/"
            Dim databaseName As String = "DBviolate"
            Dim collectionName As String = "violation_entry"

            client = New MongoClient(connectionString)
            database = client.GetDatabase(databaseName)
            collection = database.GetCollection(Of BsonDocument)(collectionName)

            Dim document As New BsonDocument()

            document.Add("AYcode", typecmb.Text)
            document.Add("Student No", studentno.Text)
            document.Add("Name", fntxt.Text)
            document.Add("Section", seccmb.Text)
            document.Add("Program", progcmb.Text)
            document.Add("YearLevel", ylcmb.Text)
            document.Add("Parents", parenttxt.Text)
            document.Add("Contact", contact.Text)
            document.Add("Type", acacmb.Text)
            document.Add("Violation", violatecmb.Text)
            document.Add("Others", othrvtxt.Text)
            document.Add("Sanction", sanccmb.Text)

            Dim imageBytes As Byte()
            Using stream As New MemoryStream()
                imgs.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                imageBytes = stream.ToArray()
            End Using

            Dim base64String As String = Convert.ToBase64String(imageBytes)
            document.Add("StudentImage", base64String)

            Dim filter = Builders(Of BsonDocument).Filter.Eq(Of Integer)("Student No", studentno.Text)
            Dim existingDocument = collection.Find(filter).FirstOrDefault()

            If existingDocument IsNot Nothing Then
                MessageBox.Show("Violation Information save failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            Else
                collection.InsertOne(document)
                MessageBox.Show("Violation Information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error inserting documents: " & ex.Message, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub velv_Click(sender As Object, e As EventArgs) Handles velv.Click
        With FMVL
            .Show()
            Me.Hide()
        End With
    End Sub

    Private Sub notif_Click(sender As Object, e As EventArgs) Handles notif.Click
        With FMNOTIF
            .Show()
            Me.Hide()
        End With
    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        Dim arrImage() As Byte
        Dim imgpath As String
        Dim opf As FileDialog = New OpenFileDialog
        opf.Filter = "Choose Your Profile Picture (.jpg;.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*jpeg"
        If opf.ShowDialog() = DialogResult.OK Then
            imgpath = opf.FileName
            imgs.SizeMode = PictureBoxSizeMode.StretchImage
            imgs.ImageLocation = imgpath
        End If
        opf = Nothing
    End Sub

    Private Sub clr_Click(sender As Object, e As EventArgs) Handles clr.Click
        acacmb.Items.Clear()
        acacmb.SelectedIndex = -1
        studentno.Clear()
        fntxt.Clear()
        seccmb.Items.Clear()
        seccmb.SelectedIndex = -1
        progcmb.Items.Clear()
        progcmb.SelectedIndex = -1
        ylcmb.Items.Clear()
        ylcmb.SelectedIndex = -1
        parenttxt.Clear()
        contact.Clear()
        typecmb.Items.Clear()
        typecmb.SelectedIndex = -1
        violatecmb.Items.Clear()
        violatecmb.SelectedIndex = -1
        othrvtxt.Clear()
        offensecmb.Items.Clear()
        offensecmb.SelectedIndex = -1
        sanccmb.Items.Clear()
        sanccmb.SelectedIndex = -1

        imgs.Image = Nothing
        ' Or use the following equivalent statement:
        ' PictureBox1.Image = New Bitmap(1, 1)
    End Sub

    Private Sub FMVE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub
End Class