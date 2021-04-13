Imports MongoDB.Driver
Imports MongoDB.Driver.Linq
Imports MongoDB.Driver.Builders
Imports MongoDB.Bson


Public Class residence

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim client As MongoClient
        Dim server As MongoServer
        Dim db As MongoDatabase
        Dim coll6 As MongoCollection


        client = New MongoClient("mongodb://localhost")
        server = client.GetServer()

        server.Connect()

        db = server.GetDatabase("dhawald7")
        coll6 = db.GetCollection(Of BsonDocument)("residence")

        Dim res As BsonDocument = New BsonDocument()

        If ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox5.Text = "" Or ComboBox7.Text = "" Then
            MsgBox("Please enter details")
            server.Disconnect()

        Else
            res.Add("Country", ComboBox7.Text)
            res.Add("State", ComboBox5.Text)
            res.Add("City", ComboBox2.Text)
            res.Add("Resident status", ComboBox1.Text)

            coll6.Insert(res)
            habits.Show()
            Me.Hide()

        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        education.Show()
        Me.Hide()
    End Sub

    Private Sub residence_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        If ComboBox7.SelectedItem = "India" Then
            ComboBox5.Items.Add("maharashtra")
            ComboBox5.Items.Add("gujarat")

        ElseIf ComboBox7.SelectedItem = "U.S"
            ComboBox5.Items.Clear
            ComboBox5.Items.Add("California")
            ComboBox5.Items.Add("Hawaii")
            ComboBox5.Items.Add("New York")
        End If
    End Sub
End Class