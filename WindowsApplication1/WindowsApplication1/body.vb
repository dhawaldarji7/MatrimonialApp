Imports MongoDB.Driver
Imports MongoDB.Driver.Linq
Imports MongoDB.Driver.Builders
Imports MongoDB.Bson

Public Class body
    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim client As MongoClient
        Dim server As MongoServer
        Dim db As MongoDatabase
        Dim coll2 As MongoCollection


        client = New MongoClient("mongodb://localhost")
        server = client.GetServer()

        server.Connect()

        db = server.GetDatabase("dhawald7")
        coll2 = db.GetCollection(Of BsonDocument)("body")

        If ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Or RadioButton1.Text = "" Or RadioButton2.Text = "" Or ComboBox4.Text = "" Or ComboBox5.Text = "" Or ComboBox7.Text = "" Then
            MsgBox("Please enter details")
            server.Disconnect()

        Else
            Dim b As BsonDocument = New BsonDocument()
            b.Add("Height", ComboBox1.Text + "ft " + ComboBox2.Text + "in")
            b.Add("Weight", ComboBox3.Text + " kgs")


            b.Add("Complexion", ComboBox4.Text)
            b.Add("Body type", ComboBox5.Text)
            b.Add("Blood Group", ComboBox7.Text)



            If RadioButton1.Checked Then
                b.Add("Challenged", RadioButton1.Text)

            ElseIf RadioButton2.Checked
                b.Add("Challenged", RadioButton2.Text)
            End If

            coll2.Insert(b)

            family.Show()
            Me.Hide()
        End If



    End Sub
End Class