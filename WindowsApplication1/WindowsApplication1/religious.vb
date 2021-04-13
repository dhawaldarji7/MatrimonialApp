Imports MongoDB.Driver
Imports MongoDB.Driver.Linq
Imports MongoDB.Driver.Builders
Imports MongoDB.Bson

Public Class religious
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim client As MongoClient
        Dim server As MongoServer
        Dim db As MongoDatabase
        Dim coll4 As MongoCollection


        client = New MongoClient("mongodb://localhost")
        server = client.GetServer()

        server.Connect()

        db = server.GetDatabase("dhawald7")
        coll4 = db.GetCollection(Of BsonDocument)("religious")

        If TextBox1.Text = "" Or TextBox2.Text = "" Or CheckBox1.Text = "" Or CheckBox3.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Please enter details")
            server.Disconnect()

        Else
            Dim r As BsonDocument = New BsonDocument()
            r.Add("Religion", TextBox7.Text)
            r.Add("Caste", TextBox1.Text)
            r.Add("Rashi", TextBox4.Text)
            r.Add("Gotra", TextBox2.Text)
            r.Add("Origin", TextBox3.Text)
            r.Add("Nakshatra", TextBox5.Text)

            If CheckBox1.Checked Then
                r.Add("Manglik", CheckBox1.Text)

            ElseIf CheckBox3.Checked
                r.Add("Manglik", CheckBox3.Text)
            End If

            coll4.Insert(r)

            education.Show()
            Me.Hide()
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        family.Show()
        Me.Hide()
    End Sub

    Private Sub religious_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class