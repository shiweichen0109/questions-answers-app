<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAnswers
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
        Me.tbAnswer = New System.Windows.Forms.TextBox()
        Me.btnAnswerSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbAnswer
        '
        Me.tbAnswer.Location = New System.Drawing.Point(24, 23)
        Me.tbAnswer.Multiline = True
        Me.tbAnswer.Name = "tbAnswer"
        Me.tbAnswer.Size = New System.Drawing.Size(610, 243)
        Me.tbAnswer.TabIndex = 1
        '
        'btnAnswerSubmit
        '
        Me.btnAnswerSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswerSubmit.Location = New System.Drawing.Point(24, 282)
        Me.btnAnswerSubmit.Name = "btnAnswerSubmit"
        Me.btnAnswerSubmit.Size = New System.Drawing.Size(610, 107)
        Me.btnAnswerSubmit.TabIndex = 2
        Me.btnAnswerSubmit.Text = "Submit"
        Me.btnAnswerSubmit.UseVisualStyleBackColor = True
        '
        'CreateAnswers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 430)
        Me.Controls.Add(Me.btnAnswerSubmit)
        Me.Controls.Add(Me.tbAnswer)
        Me.Name = "CreateAnswers"
        Me.Text = "CreateAnswers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbAnswer As TextBox
    Friend WithEvents btnAnswerSubmit As Button
End Class
