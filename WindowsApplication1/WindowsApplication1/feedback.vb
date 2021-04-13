Public Class feed
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dashboard.Show()
        Me.Hide()
        MsgBox("Feedback sent successfully")
    End Sub
End Class