
Imports MongoDB.Driver
Imports MongoDB.Driver.Linq
Imports MongoDB.Driver.Builders
Imports MongoDB.Bson

Public Class register
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Welcome.Show()
        Me.Hide()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim client As MongoClient
        Dim server As MongoServer
        Dim db As MongoDatabase
        Dim coll1 As MongoCollection


        client = New MongoClient("mongodb://localhost")
        server = client.GetServer()

        server.Connect()

        db = server.GetDatabase("dhawald7")
        coll1 = db.GetCollection(Of BsonDocument)("reg")

        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox8.Text = "" Or ComboBox3.Text = "" Or RadioButton1.Text = "" Or RadioButton2.Text = "" Or ComboBox5.Text = "" Or ComboBox6.Text = "" Or ComboBox4.Text = "" Or ComboBox7.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Please enter details")
            server.Disconnect()

        Else
            Dim r As BsonDocument = New BsonDocument()
            r.Add("Fname", TextBox2.Text)
            r.Add("Lname", TextBox1.Text)
            r.Add("DOB", ComboBox1.Text + "/" + ComboBox2.Text + "/" + ComboBox3.Text)

            If RadioButton1.Checked Then
                r.Add("Gender", RadioButton1.Text)

            ElseIf RadioButton2.Checked
                r.Add("Gender", RadioButton2.Text)
            End If

            r.Add("Religion", ComboBox5.Text)
            r.Add("Mother tongue", ComboBox6.Text)
            r.Add("Age", ComboBox8.Text)
            r.Add("Living", ComboBox4.Text)
            r.Add("Mob", ComboBox7.Text + TextBox3.Text)
            r.Add("Email", TextBox4.Text)
            r.Add("Password", TextBox5.Text)
            r.Add("Image", OpenFileDialog1.FileName)


            coll1.Insert(r)

            If CheckBox1.Checked Then
                completeprofile.Show()
                Me.Hide()

            Else
                MsgBox("Please agree the privacy policy...")

            End If
        End If

    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If

    End Sub
End Class