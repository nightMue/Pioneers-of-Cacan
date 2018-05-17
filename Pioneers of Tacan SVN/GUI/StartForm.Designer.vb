<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartForm
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartForm))
      Me.btnHost = New System.Windows.Forms.Button()
      Me.btnJoin = New System.Windows.Forms.Button()
      Me.btnExit = New System.Windows.Forms.Button()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'btnHost
      '
      Me.btnHost.Location = New System.Drawing.Point(56, 105)
      Me.btnHost.Name = "btnHost"
      Me.btnHost.Size = New System.Drawing.Size(122, 23)
      Me.btnHost.TabIndex = 0
      Me.btnHost.Text = "Host a Game"
      Me.btnHost.UseVisualStyleBackColor = True
      '
      'btnJoin
      '
      Me.btnJoin.Location = New System.Drawing.Point(56, 148)
      Me.btnJoin.Name = "btnJoin"
      Me.btnJoin.Size = New System.Drawing.Size(122, 23)
      Me.btnJoin.TabIndex = 1
      Me.btnJoin.Text = "Join a Game"
      Me.btnJoin.UseVisualStyleBackColor = True
      '
      'btnExit
      '
      Me.btnExit.Location = New System.Drawing.Point(56, 189)
      Me.btnExit.Name = "btnExit"
      Me.btnExit.Size = New System.Drawing.Size(122, 23)
      Me.btnExit.TabIndex = 2
      Me.btnExit.Text = "Quit"
      Me.btnExit.UseVisualStyleBackColor = True
      '
      'PictureBox1
      '
      Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
      Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
      Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.PictureBox1.Location = New System.Drawing.Point(44, 21)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(147, 78)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
      Me.PictureBox1.TabIndex = 3
      Me.PictureBox1.TabStop = False
      '
      'StartForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
      Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
      Me.ClientSize = New System.Drawing.Size(234, 261)
      Me.ControlBox = False
      Me.Controls.Add(Me.PictureBox1)
      Me.Controls.Add(Me.btnExit)
      Me.Controls.Add(Me.btnJoin)
      Me.Controls.Add(Me.btnHost)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
      Me.Name = "StartForm"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Pioneers of Tacan (Shitty Settlers of Catan)"
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub

   Friend WithEvents btnHost As Button
   Friend WithEvents btnJoin As Button
   Friend WithEvents btnExit As Button
   Friend WithEvents PictureBox1 As PictureBox
End Class
