Imports MongoDB.Driver
Imports MongoDB.Driver.Linq
Imports MongoDB.Driver.Builders
Imports MongoDB.Bson

Public Class occupation
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FontDialog1_Apply(sender As Object, e As EventArgs)

    End Sub

    Private Sub occupation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim client As MongoClient
        Dim server As MongoServer
        Dim db As MongoDatabase
        Dim coll8 As MongoCollection


        client = New MongoClient("mongodb://localhost")
        server = client.GetServer()

        server.Connect()

        db = server.GetDatabase("dhawald7")
        coll8 = db.GetCollection(Of BsonDocument)("occupation")

        If TextBox4.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or RadioButton1.Text = "" Or RadioButton2.Text = "" Or RadioButton3.Text = "" Then
            MsgBox("Please enter details")
            server.Disconnect()

        Else
            Dim oc As BsonDocument = New BsonDocument()

            If RadioButton1.Checked Then
                oc.Add("Occupation", RadioButton1.Text)

            ElseIf RadioButton2.Checked
                oc.Add("Occupation", RadioButton2.Text)

            ElseIf RadioButton3.Checked
                oc.Add("Occupation", RadioButton3.Text)
            End If

            oc.Add("Comapany Name", TextBox4.Text)
            oc.Add("Post", ComboBox1.Text)
            oc.Add("Annual income", ComboBox2.Text)


            coll8.Insert(oc)
            residence.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class