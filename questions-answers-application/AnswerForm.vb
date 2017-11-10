
Public Class AnswersForm
    Protected db As New db
    Protected answer_id As Integer

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

    Private Sub AnswersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAnswers()
    End Sub

    Private Sub LaodAnswerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadAnswersToolStripMenuItem.Click
        LoadAnswers()
    End Sub

    Private Sub CreateAnswersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateAnswersToolStripMenuItem.Click
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