
Imports System.Data.SqlClient
Public Class ShowAnswers
    Private Sub LoadAnswersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadAnswersToolStripMenuItem.Click

        Dim sqlcon As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283sc055;Trusted_Connection=yes;"}
        Dim sqlcmd As SqlCommand
        Dim sqlda As SqlDataAdapter
        Dim sqldataset As DataSet

        Dim query As String
        query = "SELECT * FROM  answers;"

        Try
            sqlcon.Open()
            sqlcmd = New SqlCommand(query, sqlcon)
            sqlda = New SqlDataAdapter(sqlcmd)
            sqldataset = New DataSet
            sqlda.Fill(sqldataset)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        Finally
            If sqlcon.State = ConnectionState.Open Then
                sqlcon.Close()
            End If

        End Try
    End Sub

    Private Sub CreateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem.Click

        My.Forms.CreateAnswers.Show()

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click

        My.Forms.UpdateAnswers.Show()

    End Sub

    Private Sub dgvAnswers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAnswers.CellContentClick

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim confirm As Integer = MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNoCancel)
        If confirm = DialogResult.Yes Then
            Dim sqlcon As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283cxiang;Trusted_Connection=yes;"}
            Dim sqlcmd As SqlCommand

            Dim query As String
            query = "DELETE FROM answers WHERE [id] = @answer;"
            Try
                sqlcmd = New SqlCommand(query, sqlcon)
                Dim answer_id As String = dgvAnswers.Item("id", dgvAnswers.CurrentRow.Index).Value.ToString()
                sqlcmd.Parameters.AddWithValue("@answer", answer_id)
                sqlcon.Open()
                sqlcmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw ex
            Finally
                If sqlcon.State = ConnectionState.Open Then
                    sqlcon.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub ShowAnswers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
