Imports MongoDB.Driver
Imports MongoDB.Bson
Module SVMS
    Public connectionString As String = "mongodb://localhost:27017"
    Public client As New MongoClient(connectionString)

    Public databaseName As String = "DBviolate"
    Public collectionSE As String = "student_entry"
    Public collectionVE As String = "violation_entry"
    Public collectionP As String = "program"
    Public collectionSEC As String = "section"
    Public collectionAY As String = "academic_year"
    Public collectionIR As String = "incident_report"

    Public database As IMongoDatabase = client.GetDatabase(databaseName)
End Module
