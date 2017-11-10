Public Class UpdateAnswer
    'Private v As Integer
    Protected answer_id As Integer
    Protected db As New db

    Public Sub New(ByVal aid As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        answer_id = aid

        tbUpdateAnswer.Text = welcome.getAnswerValue("answer").ToString()
    End Sub
    ' Public Sub New(v As Integer)
    'Me.v = v
    ' End Sub

    Private Sub tbUpdateQuestion_TextChanged(sender As Object, e As EventArgs) Handles tbUpdateAnswer.TextChanged

    End Sub

    Private Sub btnUpdateAnswerSubmit_Click(sender As Object, e As EventArgs) Handles btnUpdateAnswerSubmit.Click
        db.sql = "UPDATE questions SET question = @question WHERE id = @question_id"
        db.bind("@question_id", answer_id)
        db.bind("@question", tbUpdateAnswer.Text)
        db.execute()
        Me.Dispose()
    End Sub
End Class