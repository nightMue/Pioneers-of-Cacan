<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConnectForm
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
      Me.btnJoin = New System.Windows.Forms.Button()
      Me.btnBack = New System.Windows.Forms.Button()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.txtLog = New System.Windows.Forms.TextBox()
      Me.txtIPAddress = New System.Windows.Forms.TextBox()
      Me.txtPort = New System.Windows.Forms.TextBox()
      Me.SuspendLayout()
      '
      'btnJoin
      '
      Me.btnJoin.Location = New System.Drawing.Point(12, 125)
      Me.btnJoin.Name = "btnJoin"
      Me.btnJoin.Size = New System.Drawing.Size(149, 47)
      Me.btnJoin.TabIndex = 0
      Me.btnJoin.Text = "Join"
      Me.btnJoin.UseVisualStyleBackColor = True
      '
      'btnBack
      '
      Me.btnBack.Location = New System.Drawing.Point(12, 183)
      Me.btnBack.Name = "btnBack"
      Me.btnBack.Size = New System.Drawing.Size(149, 47)
      Me.btnBack.TabIndex = 1
      Me.btnBack.Text = "Back"
      Me.btnBack.UseVisualStyleBackColor = True
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(12, 20)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(58, 13)
      Me.Label1.TabIndex = 4
      Me.Label1.Text = "IP Address"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(12, 72)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(26, 13)
      Me.Label2.TabIndex = 5
      Me.Label2.Text = "Port"
      '
      'txtLog
      '
      Me.txtLog.Location = New System.Drawing.Point(176, 13)
      Me.txtLog.Multiline = True
      Me.txtLog.Name = "txtLog"
      Me.txtLog.Size = New System.Drawing.Size(247, 217)
      Me.txtLog.TabIndex = 6
      '
      'txtIPAddress
      '
      Me.txtIPAddress.Location = New System.Drawing.Point(15, 37)
      Me.txtIPAddress.Name = "txtIPAddress"
      Me.txtIPAddress.Size = New System.Drawing.Size(146, 20)
      Me.txtIPAddress.TabIndex = 7
      '
      'txtPort
      '
      Me.txtPort.Location = New System.Drawing.Point(15, 88)
      Me.txtPort.MaxLength = 5
      Me.txtPort.Name = "txtPort"
      Me.txtPort.Size = New System.Drawing.Size(146, 20)
      Me.txtPort.TabIndex = 8
      '
      'ClientForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(435, 242)
      Me.ControlBox = False
      Me.Controls.Add(Me.txtPort)
      Me.Controls.Add(Me.txtIPAddress)
      Me.Controls.Add(Me.txtLog)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.btnBack)
      Me.Controls.Add(Me.btnJoin)
      Me.Name = "ClientForm"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Join a game"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents btnJoin As Button
   Friend WithEvents btnBack As Button
   Friend WithEvents Label1 As Label
   Friend WithEvents Label2 As Label
   Friend WithEvents txtLog As TextBox
   Friend WithEvents txtIPAddress As TextBox
   Friend WithEvents txtPort As TextBox
End Class
