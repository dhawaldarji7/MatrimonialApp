
Imports MongoDB.Driver
Imports MongoDB.Driver.Linq
Imports MongoDB.Driver.Builders
Imports MongoDB.Bson

Public Class Log
    Dim bclicked As Boolean = False

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Welcome.Show()
        Me.Hide()
    End Sub

    Private Sub Log_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim client As MongoClient
        Dim server As MongoServer
        Dim db As MongoDatabase
        Dim coll As MongoCollection

        Dim flg = 0
        client = New MongoClient("mongodb://localhost")
        server = client.GetServer()

        server.Connect()

        db = server.GetDatabase("dhawald7")
        coll = db.GetCollection(Of BsonDocument)("reg")

        Dim query1 As QueryDocument = New QueryDocument("Email", TextBox1.Text)

        For Each item As BsonDocument In coll.FindAs(Of BsonDocument)(query1)
            Dim username As BsonElement = item.GetElement("Email")
            Dim pass As BsonElement = item.GetElement("Password")
            ' Dim img As BsonElement = item.GetElement("Image")
            ' Dim epass As String = encryptPassword(TextBox2.Text)
            ' MsgBox(epass)

            If (TextBox1.Text = username.Value) Then
                If (TextBox2.Text = pass.Value) Then
                    ' PictureBox1.Image = Image.FromFile(item("Image"))
                    flg = 1
                End If
            End If

        Next

        If flg <> 1 Then


            MsgBox("Please enter correct User ID & Password", MsgBoxStyle.Critical)
        Else

            server.Disconnect()

            MsgBox("You have successfully logged in")

            Dashboard.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class