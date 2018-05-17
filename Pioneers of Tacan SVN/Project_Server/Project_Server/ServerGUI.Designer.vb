<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServerGUI
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
      Me.txtLog = New System.Windows.Forms.TextBox()
      Me.btnBack = New System.Windows.Forms.Button()
      Me.btnGameStart = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'txtLog
      '
      Me.txtLog.Location = New System.Drawing.Point(12, 13)
      Me.txtLog.Multiline = True
      Me.txtLog.Name = "txtLog"
      Me.txtLog.Size = New System.Drawing.Size(246, 236)
      Me.txtLog.TabIndex = 0
      '
      'btnBack
      '
      Me.btnBack.Location = New System.Drawing.Point(274, 194)
      Me.btnBack.Name = "btnBack"
      Me.btnBack.Size = New System.Drawing.Size(109, 55)
      Me.btnBack.TabIndex = 2
      Me.btnBack.Text = "Back"
      Me.btnBack.UseVisualStyleBackColor = True
      '
      'btnGameStart
      '
      Me.btnGameStart.Location = New System.Drawing.Point(274, 13)
      Me.btnGameStart.Name = "btnGameStart"
      Me.btnGameStart.Size = New System.Drawing.Size(109, 55)
      Me.btnGameStart.TabIndex = 4
      Me.btnGameStart.Text = "Start Game"
      Me.btnGameStart.UseVisualStyleBackColor = True
      '
      'ServerGUI
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(395, 261)
      Me.ControlBox = False
      Me.Controls.Add(Me.btnGameStart)
      Me.Controls.Add(Me.btnBack)
      Me.Controls.Add(Me.txtLog)
      Me.Name = "ServerGUI"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Host a game"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents txtLog As TextBox
   Friend WithEvents btnBack As Button
   Friend WithEvents btnGameStart As Button
End Class
