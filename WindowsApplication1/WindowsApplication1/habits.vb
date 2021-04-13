Imports MongoDB.Driver
Imports MongoDB.Driver.Linq
Imports MongoDB.Driver.Builders
Imports MongoDB.Bson
Public Class habits
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim client As MongoClient
        Dim server As MongoServer
        Dim db As MongoDatabase
        Dim coll7 As MongoCollection


        client = New MongoClient("mongodb://localhost")
        server = client.GetServer()

        server.Connect()

        db = server.GetDatabase("dhawald7")
        coll7 = db.GetCollection(Of BsonDocument)("habits")

        If TextBox1.Text = "" Or CheckBox1.Text = "" Or CheckBox2.Text = "" Or CheckBox3.Text = "" Or CheckBox4.Text = "" Or CheckBox4.Text = "" Or CheckBox5.Text = "" Or CheckBox6.Text = "" Then
            MsgBox("Please enter details")
            server.Disconnect()

        Else
            Dim hb As BsonDocument = New BsonDocument()

            If CheckBox1.Checked Then
                hb.Add("Smoking", CheckBox1.Text)

            ElseIf CheckBox2.Checked
                hb.Add("Smoking", CheckBox2.Text)

            ElseIf CheckBox3.Checked
                hb.Add("Smoking", CheckBox3.Text)
            End If

            If CheckBox4.Checked Then
                hb.Add("Drinking", CheckBox4.Text)

            ElseIf CheckBox5.Checked
                hb.Add("Drinking", CheckBox5.Text)

            ElseIf CheckBox6.Checked
                hb.Add("Drinking", CheckBox6.Text)
            End If

            hb.Add("Hobbies", TextBox1.Text)

            coll7.Insert(hb)
            MsgBox("Your profile is now complete...Press ok to continue")
            Dashboard.Show()
            Me.Hide()

        End If






    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        residence.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub habits_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class