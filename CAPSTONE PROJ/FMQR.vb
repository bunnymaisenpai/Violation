Imports MongoDB.Driver
Imports MongoDB.Bson
Imports System.IO
Imports ZXing.Common
Imports ZXing
Imports ZXing.QrCode
Imports System.Text.RegularExpressions

Public Class FMQR
    Dim pic As Bitmap = New Bitmap(190, 190)
    Dim gfx As Graphics = Graphics.FromImage(pic)
    Private database As IMongoDatabase
    Private collection As IMongoCollection(Of BsonDocument)
    Private client As MongoClient
    Private Sub svebtn_Click(sender As Object, e As EventArgs) Handles svebtn.Click
        Try
            Dim connectionString As String = "mongodb+srv://atlas:atlas@cluster0.sktubmk.mongodb.net/"
            Dim databaseName As String = "DBviolate"
            Dim collectionName As String = "student_entry"

            client = New MongoClient(connectionString)
            database = client.GetDatabase(databaseName)
            collection = database.GetCollection(Of BsonDocument)(collectionName)

            Dim document As New BsonDocument()
            document.Add("qrscan", scantxt.Text)
            collection.InsertOne(document)

            MessageBox.Show("Incident Report saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error inserting documents: " & ex.Message, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        gfx.CopyFromScreen(New Point(Me.Location.X + PictureBox1.Location.X + 4, Me.Location.Y + PictureBox1.Location.Y + 30), New Point(0, 0), pic.Size)
        PictureBox1.Image = pic
        PictureBox1.Image = Nothing
    End Sub

    Private Sub QR_Click(sender As Object, e As EventArgs) Handles QR.Click
        Dim pic As Bitmap = New Bitmap(190, 190)

        PictureBox2.Image = pic

        Dim Reader As New BarcodeReader()
        Dim result As Result = Reader.Decode(pic)

        Try
            If result IsNot Nothing Then
                Dim decoded As String = result.Text.Trim()

                Dim pattern As String = "Violator Name: ([^,]+), Student Number: ([^,]+), Strand: ([^,]+), Year and Section: ([^,]+), Report: ([^,]+), Reported By: (.+)"
                Dim match As Match = Regex.Match(decoded, pattern)

                If match.Success Then
                    Dim violatorName As String = match.Groups(1).Value
                    Dim studentNumber As String = match.Groups(2).Value
                    Dim strand As String = match.Groups(3).Value
                    Dim yearAndSection As String = match.Groups(4).Value
                    Dim report As String = match.Groups(5).Value
                    Dim reportedBy As String = match.Groups(6).Value

                    MessageBox.Show($"Violator Name: {violatorName}, Student Number: {studentNumber}, Strand: {strand}, Year and Section: {yearAndSection}, Report: {report}, Reported By: {reportedBy}")

                    scantxt.Text = $"Violator Name: {violatorName}, Student Number: {studentNumber}, Strand: {strand}, Year and Section: {yearAndSection}, Report: {report}, Reported By: {reportedBy}"
                Else
                    scantxt.Text = "Invalid QR code format"
                End If
            Else
                scantxt.Text = "No QR code found"
            End If
        Catch ex As Exception
            MessageBox.Show("Error decoding QR code: " & ex.Message)
        End Try
    End Sub


    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        With FMINCIDENT
            .Show()
            Me.Hide()
        End With
    End Sub
End Class