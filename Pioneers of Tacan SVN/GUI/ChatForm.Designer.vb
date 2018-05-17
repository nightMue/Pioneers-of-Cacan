<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChatForm
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()>
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
   <System.Diagnostics.DebuggerStepThrough()>
   Private Sub InitializeComponent()
      Me.ChatLog = New System.Windows.Forms.RichTextBox()
      Me.txtChat = New System.Windows.Forms.TextBox()
      Me.btnChat = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'ChatLog
      '
      Me.ChatLog.BackColor = System.Drawing.SystemColors.Window
      Me.ChatLog.Location = New System.Drawing.Point(19, 20)
      Me.ChatLog.Margin = New System.Windows.Forms.Padding(2)
      Me.ChatLog.Name = "ChatLog"
      Me.ChatLog.ReadOnly = True
      Me.ChatLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
      Me.ChatLog.Size = New System.Drawing.Size(198, 279)
      Me.ChatLog.TabIndex = 0
      Me.ChatLog.Text = ""
      '
      'txtChat
      '
      Me.txtChat.Location = New System.Drawing.Point(19, 311)
      Me.txtChat.Margin = New System.Windows.Forms.Padding(2)
      Me.txtChat.Multiline = True
      Me.txtChat.Name = "txtChat"
      Me.txtChat.Size = New System.Drawing.Size(198, 34)
      Me.txtChat.TabIndex = 1
      '
      'btnChat
      '
      Me.btnChat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnChat.Location = New System.Drawing.Point(138, 350)
      Me.btnChat.Name = "btnChat"
      Me.btnChat.Size = New System.Drawing.Size(79, 23)
      Me.btnChat.TabIndex = 2
      Me.btnChat.Text = "Send Chat"
      Me.btnChat.UseVisualStyleBackColor = True
      '
      'ChatForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.White
      Me.ClientSize = New System.Drawing.Size(225, 569)
      Me.ControlBox = False
      Me.Controls.Add(Me.btnChat)
      Me.Controls.Add(Me.txtChat)
      Me.Controls.Add(Me.ChatLog)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
      Me.KeyPreview = True
      Me.Margin = New System.Windows.Forms.Padding(2)
      Me.Name = "ChatForm"
      Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
      Me.Text = "ChatForm"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents ChatLog As RichTextBox
   Friend WithEvents txtChat As TextBox
   Friend WithEvents btnChat As Button
End Class
