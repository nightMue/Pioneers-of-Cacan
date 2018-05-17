<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiscoveryPlayForm
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
      Me.Label1 = New System.Windows.Forms.Label()
      Me.btnOre = New System.Windows.Forms.Button()
      Me.btnClay = New System.Windows.Forms.Button()
      Me.btnWool = New System.Windows.Forms.Button()
      Me.btnWood = New System.Windows.Forms.Button()
      Me.btnWheat = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Location = New System.Drawing.Point(60, 22)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(170, 26)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "Select which recource you " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "wish to receive 2 of from the bank!"
      Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'btnOre
      '
      Me.btnOre.Location = New System.Drawing.Point(12, 69)
      Me.btnOre.Name = "btnOre"
      Me.btnOre.Size = New System.Drawing.Size(74, 46)
      Me.btnOre.TabIndex = 1
      Me.btnOre.Text = "Ore"
      Me.btnOre.UseVisualStyleBackColor = True
      '
      'btnClay
      '
      Me.btnClay.Location = New System.Drawing.Point(105, 69)
      Me.btnClay.Name = "btnClay"
      Me.btnClay.Size = New System.Drawing.Size(74, 46)
      Me.btnClay.TabIndex = 2
      Me.btnClay.Text = "Clay"
      Me.btnClay.UseVisualStyleBackColor = True
      '
      'btnWool
      '
      Me.btnWool.Location = New System.Drawing.Point(198, 69)
      Me.btnWool.Name = "btnWool"
      Me.btnWool.Size = New System.Drawing.Size(74, 46)
      Me.btnWool.TabIndex = 3
      Me.btnWool.Text = "Wool"
      Me.btnWool.UseVisualStyleBackColor = True
      '
      'btnWood
      '
      Me.btnWood.Location = New System.Drawing.Point(55, 131)
      Me.btnWood.Name = "btnWood"
      Me.btnWood.Size = New System.Drawing.Size(74, 46)
      Me.btnWood.TabIndex = 4
      Me.btnWood.Text = "Wood"
      Me.btnWood.UseVisualStyleBackColor = True
      '
      'btnWheat
      '
      Me.btnWheat.Location = New System.Drawing.Point(152, 131)
      Me.btnWheat.Name = "btnWheat"
      Me.btnWheat.Size = New System.Drawing.Size(74, 46)
      Me.btnWheat.TabIndex = 5
      Me.btnWheat.Text = "Wheat"
      Me.btnWheat.UseVisualStyleBackColor = True
      '
      'DiscoveryPlayForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.ActiveCaption
      Me.BackgroundImage = Global.Pioneers_of_Tacan.My.Resources.Resources.shitty_background
      Me.ClientSize = New System.Drawing.Size(284, 205)
      Me.ControlBox = False
      Me.Controls.Add(Me.btnWheat)
      Me.Controls.Add(Me.btnWood)
      Me.Controls.Add(Me.btnWool)
      Me.Controls.Add(Me.btnClay)
      Me.Controls.Add(Me.btnOre)
      Me.Controls.Add(Me.Label1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
      Me.Name = "DiscoveryPlayForm"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Discovery Card"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents Label1 As Label
   Friend WithEvents btnOre As Button
   Friend WithEvents btnClay As Button
   Friend WithEvents btnWool As Button
   Friend WithEvents btnWood As Button
   Friend WithEvents btnWheat As Button
End Class
