Public Class Welcome
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Log.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        register.Show()
        Me.Hide()
    End Sub
End Class