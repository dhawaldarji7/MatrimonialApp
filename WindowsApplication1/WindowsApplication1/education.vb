Imports MongoDB.Driver
Imports MongoDB.Driver.Linq
Imports MongoDB.Driver.Builders
Imports MongoDB.Bson

Public Class education



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim client As MongoClient
        Dim server As MongoServer
        Dim db As MongoDatabase
        Dim coll5 As MongoCollection


        client = New MongoClient("mongodb://localhost")
        server = client.GetServer()

        server.Connect()

        db = server.GetDatabase("dhawald7")
        coll5 = db.GetCollection(Of BsonDocument)("education")

        If TextBox1.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or RadioButton1.Text = "" Or RadioButton2.Text = "" Then
            MsgBox("Please enter details")
            server.Disconnect()

        Else
            Dim ed As BsonDocument = New BsonDocument()

            If RadioButton1.Checked Then
                ed.Add("Status", RadioButton1.Text)

            ElseIf RadioButton2.Checked
                ed.Add("Status", RadioButton2.Text)

            End If

            ed.Add("Qualification", ComboBox1.Text)
            ed.Add("Degree", ComboBox2.Text)
            ed.Add("Graduated From", TextBox1.Text)

            coll5.Insert(ed)

            occupation.Show()
            Me.Hide()
        End If



    End Sub

    Private Sub education_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "engineer" Then
            ComboBox2.Items.Add("be it")
            ComboBox2.Items.Add("be comp")

        ElseIf ComboBox1.SelectedItem = "doctor"
            ComboBox2.Items.Clear
            ComboBox2.Items.Add("mbbs")
        End If


    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            ComboBox1.Visible = False
            ComboBox2.Visible = False
            TextBox1.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            ComboBox1.Visible = True
            ComboBox2.Visible = True
            TextBox1.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
        End If
    End Sub
End Class