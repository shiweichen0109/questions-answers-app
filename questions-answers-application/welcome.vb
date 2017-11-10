
Public Class welcome
    Protected db As New db
    Protected answer_id As Integer

    Protected Sub LoadQuestions()
        db.sql = "SELECT * FROM questions ORDER BY created_at DESC;"
        db.fill(dgvQuestions)
    End Sub
    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        LoadQuestions()
    End Sub

    Private Sub welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadQuestions()
    End Sub

    Private Sub CreateQuestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateQuestionToolStripMenuItem.Click
        CreateQuestion.ShowDialog()
        LoadQuestions()
    End Sub

    Private Sub UpdateQuestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateQuestionToolStripMenuItem.Click
        Dim updateQuestionForm As New UpdateQuestion(getQuestionId())
        updateQuestionForm.ShowDialog()
        LoadQuestions()
    End Sub

    Public Function getQuestionId() As Integer
        Return getQuestionValue("id")
    End Function

    Public Function getQuestionValue(ByVal column As String)
        Return dgvQuestions.Item(column, dgvQuestions.CurrentRow.Index).Value
    End Function

    Private Sub DeleteQuestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteQuestionToolStripMenuItem.Click
        Dim confirmed As Integer = MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNoCancel)

        If confirmed = DialogResult.Yes Then
            MsgBox("Deleted")
            db.sql = "DELETE FROM questions WHERE id = @question_id"
            db.bind("@question_id", getQuestionId())
            db.execute()
            LoadQuestions()

        End If
    End Sub

    Private Sub ShowAnswerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAnswerToolStripMenuItem.Click
        Dim answersForm As New AnswersForm(getQuestionId())
        answersForm.ShowDialog()
    End Sub

    Private Sub dgvQuestions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvQuestions.CellContentClick

    End Sub

    Private Sub LoanAnswersToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LoanAnswersToolStripMenuItem.Click
        LoadAnswers()
    End Sub


    Public Sub New(ByRef aid As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        answer_id = aid
    End Sub

    Protected Sub LoadAnswers()
        db.sql = "SELECT * FROM answers WHERE asnwer_id = @answer_id"
        db.bind("@answer_id", answer_id)
        db.fill(dgvAnswers)
    End Sub
    Private Sub CreateAnswerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateAnswerToolStripMenuItem.Click
        CreateAnswer.ShowDialog()
        LoadAnswers()
    End Sub
    Private Sub UpdateAnswerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAnswerToolStripMenuItem.Click
        Dim updateAnswerForm As New UpdateAnswer(getAnswerId())
        updateAnswerForm.ShowDialog()
        LoadAnswers()
    End Sub
    Public Function getAnswerId() As Integer
        Return getAnswerValue("id")
    End Function

    Public Function getAnswerValue(ByVal column As String)
        Return dgvAnswers.Item(column, dgvAnswers.CurrentRow.Index).Value
    End Function
    Private Sub DeleteAnswerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAnswerToolStripMenuItem.Click
        Dim confirmed As Integer = MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNoCancel)

        If confirmed = DialogResult.Yes Then
            MsgBox("Deleted")
            db.sql = "DELETE FROM answers WHERE id = @answer_id"
            db.bind("@answer_id", getAnswerId())
            db.execute()
            LoadAnswers()

        End If
    End Sub

    Private Sub dgvAnswers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAnswers.CellContentClick

    End Sub

End Class
