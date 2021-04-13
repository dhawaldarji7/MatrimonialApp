Imports MongoDB.Driver
Imports MongoDB.Driver.Linq
Imports MongoDB.Driver.Builders
Imports MongoDB.Bson
Public Class family
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim client As MongoClient
        Dim server As MongoServer
        Dim db As MongoDatabase
        Dim coll3 As MongoCollection


        client = New MongoClient("mongodb://localhost")
        server = client.GetServer()

        server.Connect()

        db = server.GetDatabase("dhawald7")
        coll3 = db.GetCollection(Of BsonDocument)("family")

        If ComboBox1.Text = "" Or ComboBox4.Text = "" Or CheckBox1.Text = "" Or RadioButton1.Text = "" Or RadioButton2.Text = "" Or CheckBox2.Text = "" Or TextBox1.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Please enter details")
            server.Disconnect()

        Else
            Dim f As BsonDocument = New BsonDocument()
            f.Add("Family type", ComboBox4.Text)
            f.Add("Father's Name", TextBox4.Text)
            f.Add("Mother's Name", TextBox1.Text)
            f.Add("Members", ComboBox1.Text)


            If CheckBox1.Checked Then
                f.Add("Siblings", CheckBox1.Text)

            ElseIf CheckBox2.Checked
                f.Add("Siblings", CheckBox2.Text)
            End If

            If RadioButton1.Checked Then
                f.Add("Lives with", RadioButton1.Text)

            ElseIf RadioButton2.Checked
                f.Add("Lives with", RadioButton2.Text)
            End If

            coll3.Insert(f)
            religious.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        body.Show()
        Me.Hide()
    End Sub
End Class