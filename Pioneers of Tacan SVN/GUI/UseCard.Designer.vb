<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UseCard
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
      Me.btnKnightUse = New System.Windows.Forms.Button()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.btnDiscoveryUse = New System.Windows.Forms.Button()
      Me.btnRoadBuilderUse = New System.Windows.Forms.Button()
      Me.btnMonopolyUse = New System.Windows.Forms.Button()
      Me.btnBack = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'btnKnightUse
      '
      Me.btnKnightUse.Location = New System.Drawing.Point(32, 56)
      Me.btnKnightUse.Name = "btnKnightUse"
      Me.btnKnightUse.Size = New System.Drawing.Size(96, 61)
      Me.btnKnightUse.TabIndex = 0
      Me.btnKnightUse.Text = "Knight"
      Me.btnKnightUse.UseVisualStyleBackColor = True
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Location = New System.Drawing.Point(94, 20)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(96, 13)
      Me.Label1.TabIndex = 1
      Me.Label1.Text = "Select Card to Use"
      '
      'btnDiscoveryUse
      '
      Me.btnDiscoveryUse.Location = New System.Drawing.Point(157, 56)
      Me.btnDiscoveryUse.Name = "btnDiscoveryUse"
      Me.btnDiscoveryUse.Size = New System.Drawing.Size(96, 61)
      Me.btnDiscoveryUse.TabIndex = 2
      Me.btnDiscoveryUse.Text = "Discovery"
      Me.btnDiscoveryUse.UseVisualStyleBackColor = True
      '
      'btnRoadBuilderUse
      '
      Me.btnRoadBuilderUse.Location = New System.Drawing.Point(32, 144)
      Me.btnRoadBuilderUse.Name = "btnRoadBuilderUse"
      Me.btnRoadBuilderUse.Size = New System.Drawing.Size(96, 61)
      Me.btnRoadBuilderUse.TabIndex = 3
      Me.btnRoadBuilderUse.Text = "Road Builder"
      Me.btnRoadBuilderUse.UseVisualStyleBackColor = True
      '
      'btnMonopolyUse
      '
      Me.btnMonopolyUse.Location = New System.Drawing.Point(157, 144)
      Me.btnMonopolyUse.Name = "btnMonopolyUse"
      Me.btnMonopolyUse.Size = New System.Drawing.Size(96, 61)
      Me.btnMonopolyUse.TabIndex = 4
      Me.btnMonopolyUse.Text = "Monopoly"
      Me.btnMonopolyUse.UseVisualStyleBackColor = True
      '
      'btnBack
      '
      Me.btnBack.Location = New System.Drawing.Point(105, 226)
      Me.btnBack.Name = "btnBack"
      Me.btnBack.Size = New System.Drawing.Size(75, 23)
      Me.btnBack.TabIndex = 5
      Me.btnBack.Text = "Cancel"
      Me.btnBack.UseVisualStyleBackColor = True
      '
      'UseCard
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.ActiveCaption
      Me.BackgroundImage = Global.Pioneers_of_Tacan.My.Resources.Resources.shitty_background
      Me.ClientSize = New System.Drawing.Size(284, 261)
      Me.ControlBox = False
      Me.Controls.Add(Me.btnBack)
      Me.Controls.Add(Me.btnMonopolyUse)
      Me.Controls.Add(Me.btnRoadBuilderUse)
      Me.Controls.Add(Me.btnDiscoveryUse)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.btnKnightUse)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
      Me.Name = "UseCard"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Use Development Card"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents btnKnightUse As Button
   Friend WithEvents Label1 As Label
   Friend WithEvents btnDiscoveryUse As Button
   Friend WithEvents btnRoadBuilderUse As Button
   Friend WithEvents btnMonopolyUse As Button
   Friend WithEvents btnBack As Button
End Class
