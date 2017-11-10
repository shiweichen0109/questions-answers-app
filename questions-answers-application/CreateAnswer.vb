Public Class CreateAnswer
    Protected db As db = New db
    Private Sub tbAnswer_TextChanged(sender As Object, e As EventArgs) Handles tbAnswer.TextChanged

    End Sub

    Private Sub btnAnswerSubmit_Click(sender As Object, e As EventArgs) Handles btnAnswerSubmit.Click
        db.sql = "INSERT INTO answers (answer) VALUES (@answer)"
        db.bind("@answer", tbAnswer.Text)
        db.execute()
        Me.Dispose()
    End Sub
End Class