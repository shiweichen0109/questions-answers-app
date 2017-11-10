<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class welcome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.welcomeMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateQuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateQuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteQuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowAnswerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanAnswersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateAnswerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateAnswerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAnswerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvQuestions = New System.Windows.Forms.DataGridView()
        Me.dgvAnswers = New System.Windows.Forms.DataGridView()
        Me.welcomeMenuStrip.SuspendLayout()
        CType(Me.dgvQuestions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAnswers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'welcomeMenuStrip
        '
        Me.welcomeMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadToolStripMenuItem, Me.CreateQuestionToolStripMenuItem, Me.UpdateQuestionToolStripMenuItem, Me.DeleteQuestionToolStripMenuItem, Me.ShowAnswerToolStripMenuItem, Me.LoanAnswersToolStripMenuItem, Me.CreateAnswerToolStripMenuItem, Me.UpdateAnswerToolStripMenuItem, Me.DeleteAnswerToolStripMenuItem})
        Me.welcomeMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.welcomeMenuStrip.Name = "welcomeMenuStrip"
        Me.welcomeMenuStrip.Size = New System.Drawing.Size(1014, 24)
        Me.welcomeMenuStrip.TabIndex = 0
        Me.welcomeMenuStrip.Text = "MenuStrip1"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(140, 20)
        Me.LoadToolStripMenuItem.Text = "Load Recent Questions"
        '
        'CreateQuestionToolStripMenuItem
        '
        Me.CreateQuestionToolStripMenuItem.Name = "CreateQuestionToolStripMenuItem"
        Me.CreateQuestionToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.CreateQuestionToolStripMenuItem.Text = "Create Question"
        '
        'UpdateQuestionToolStripMenuItem
        '
        Me.UpdateQuestionToolStripMenuItem.Name = "UpdateQuestionToolStripMenuItem"
        Me.UpdateQuestionToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.UpdateQuestionToolStripMenuItem.Text = "Update Question"
        '
        'DeleteQuestionToolStripMenuItem
        '
        Me.DeleteQuestionToolStripMenuItem.Name = "DeleteQuestionToolStripMenuItem"
        Me.DeleteQuestionToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.DeleteQuestionToolStripMenuItem.Text = "Delete Question"
        '
        'ShowAnswerToolStripMenuItem
        '
        Me.ShowAnswerToolStripMenuItem.Name = "ShowAnswerToolStripMenuItem"
        Me.ShowAnswerToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.ShowAnswerToolStripMenuItem.Text = "Show Answer"
        '
        'LoanAnswersToolStripMenuItem
        '
        Me.LoanAnswersToolStripMenuItem.Name = "LoanAnswersToolStripMenuItem"
        Me.LoanAnswersToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.LoanAnswersToolStripMenuItem.Text = "Loan Answers"
        '
        'CreateAnswerToolStripMenuItem
        '
        Me.CreateAnswerToolStripMenuItem.Name = "CreateAnswerToolStripMenuItem"
        Me.CreateAnswerToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.CreateAnswerToolStripMenuItem.Text = "Create Answer"
        '
        'UpdateAnswerToolStripMenuItem
        '
        Me.UpdateAnswerToolStripMenuItem.Name = "UpdateAnswerToolStripMenuItem"
        Me.UpdateAnswerToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.UpdateAnswerToolStripMenuItem.Text = "Update Answer"
        '
        'DeleteAnswerToolStripMenuItem
        '
        Me.DeleteAnswerToolStripMenuItem.Name = "DeleteAnswerToolStripMenuItem"
        Me.DeleteAnswerToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.DeleteAnswerToolStripMenuItem.Text = "Delete Answer"
        '
        'dgvQuestions
        '
        Me.dgvQuestions.AllowUserToAddRows = False
        Me.dgvQuestions.AllowUserToDeleteRows = False
        Me.dgvQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuestions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvQuestions.Location = New System.Drawing.Point(0, 24)
        Me.dgvQuestions.Name = "dgvQuestions"
        Me.dgvQuestions.ReadOnly = True
        Me.dgvQuestions.Size = New System.Drawing.Size(1014, 586)
        Me.dgvQuestions.TabIndex = 1
        '
        'dgvAnswers
        '
        Me.dgvAnswers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAnswers.Location = New System.Drawing.Point(0, 27)
        Me.dgvAnswers.Name = "dgvAnswers"
        Me.dgvAnswers.Size = New System.Drawing.Size(1014, 583)
        Me.dgvAnswers.TabIndex = 2
        '
        'welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 610)
        Me.Controls.Add(Me.dgvAnswers)
        Me.Controls.Add(Me.dgvQuestions)
        Me.Controls.Add(Me.welcomeMenuStrip)
        Me.MainMenuStrip = Me.welcomeMenuStrip
        Me.Name = "welcome"
        Me.Text = "Welcome"
        Me.welcomeMenuStrip.ResumeLayout(False)
        Me.welcomeMenuStrip.PerformLayout()
        CType(Me.dgvQuestions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAnswers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents welcomeMenuStrip As MenuStrip
    Friend WithEvents LoadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvQuestions As DataGridView
    Friend WithEvents CreateQuestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateQuestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteQuestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoanAnswersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateAnswerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateAnswerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteAnswerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowAnswerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvAnswers As DataGridView
End Class
