Public Class Dashboard
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Search.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        advsearch.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        feed.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        About_us.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Welcome.Show()
        Me.Hide()
        MsgBox("You have logged out")
    End Sub
End Class