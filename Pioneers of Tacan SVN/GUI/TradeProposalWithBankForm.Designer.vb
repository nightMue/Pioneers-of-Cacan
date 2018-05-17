<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TradeProposalWithBankForm
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
      Me.btnCancel = New System.Windows.Forms.Button()
      Me.btnSend = New System.Windows.Forms.Button()
      Me.gbTheirs = New System.Windows.Forms.GroupBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.txtTheirQuantity = New System.Windows.Forms.TextBox()
      Me.rbTheirClay = New System.Windows.Forms.RadioButton()
      Me.rbTheirWool = New System.Windows.Forms.RadioButton()
      Me.rbTheirWheat = New System.Windows.Forms.RadioButton()
      Me.rbTheirWood = New System.Windows.Forms.RadioButton()
      Me.rbTheirOre = New System.Windows.Forms.RadioButton()
      Me.gbYours = New System.Windows.Forms.GroupBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.txtQuantity = New System.Windows.Forms.TextBox()
      Me.rbOre = New System.Windows.Forms.RadioButton()
      Me.rbWheat = New System.Windows.Forms.RadioButton()
      Me.rbClay = New System.Windows.Forms.RadioButton()
      Me.rbWool = New System.Windows.Forms.RadioButton()
      Me.rbWood = New System.Windows.Forms.RadioButton()
      Me.gbTheirs.SuspendLayout()
      Me.gbYours.SuspendLayout()
      Me.SuspendLayout()
      '
      'btnCancel
      '
      Me.btnCancel.Location = New System.Drawing.Point(59, 247)
      Me.btnCancel.Name = "btnCancel"
      Me.btnCancel.Size = New System.Drawing.Size(75, 23)
      Me.btnCancel.TabIndex = 13
      Me.btnCancel.Text = "Cancel"
      Me.btnCancel.UseVisualStyleBackColor = True
      '
      'btnSend
      '
      Me.btnSend.Location = New System.Drawing.Point(189, 247)
      Me.btnSend.Name = "btnSend"
      Me.btnSend.Size = New System.Drawing.Size(75, 23)
      Me.btnSend.TabIndex = 12
      Me.btnSend.Text = "Send"
      Me.btnSend.UseVisualStyleBackColor = True
      '
      'gbTheirs
      '
      Me.gbTheirs.BackColor = System.Drawing.Color.Transparent
      Me.gbTheirs.Controls.Add(Me.Label1)
      Me.gbTheirs.Controls.Add(Me.txtTheirQuantity)
      Me.gbTheirs.Controls.Add(Me.rbTheirClay)
      Me.gbTheirs.Controls.Add(Me.rbTheirWool)
      Me.gbTheirs.Controls.Add(Me.rbTheirWheat)
      Me.gbTheirs.Controls.Add(Me.rbTheirWood)
      Me.gbTheirs.Controls.Add(Me.rbTheirOre)
      Me.gbTheirs.Location = New System.Drawing.Point(4, 133)
      Me.gbTheirs.Name = "gbTheirs"
      Me.gbTheirs.Size = New System.Drawing.Size(315, 100)
      Me.gbTheirs.TabIndex = 11
      Me.gbTheirs.TabStop = False
      Me.gbTheirs.Text = "Banks Recource"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(88, 63)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(49, 13)
      Me.Label1.TabIndex = 6
      Me.Label1.Text = "Quantity:"
      '
      'txtTheirQuantity
      '
      Me.txtTheirQuantity.Enabled = False
      Me.txtTheirQuantity.Location = New System.Drawing.Point(143, 60)
      Me.txtTheirQuantity.Name = "txtTheirQuantity"
      Me.txtTheirQuantity.Size = New System.Drawing.Size(62, 20)
      Me.txtTheirQuantity.TabIndex = 5
      Me.txtTheirQuantity.Text = "1"
      '
      'rbTheirClay
      '
      Me.rbTheirClay.AutoSize = True
      Me.rbTheirClay.Location = New System.Drawing.Point(252, 20)
      Me.rbTheirClay.Name = "rbTheirClay"
      Me.rbTheirClay.Size = New System.Drawing.Size(45, 17)
      Me.rbTheirClay.TabIndex = 4
      Me.rbTheirClay.TabStop = True
      Me.rbTheirClay.Text = "Clay"
      Me.rbTheirClay.UseVisualStyleBackColor = True
      '
      'rbTheirWool
      '
      Me.rbTheirWool.AutoSize = True
      Me.rbTheirWool.Location = New System.Drawing.Point(192, 20)
      Me.rbTheirWool.Name = "rbTheirWool"
      Me.rbTheirWool.Size = New System.Drawing.Size(50, 17)
      Me.rbTheirWool.TabIndex = 3
      Me.rbTheirWool.TabStop = True
      Me.rbTheirWool.Text = "Wool"
      Me.rbTheirWool.UseVisualStyleBackColor = True
      '
      'rbTheirWheat
      '
      Me.rbTheirWheat.AutoSize = True
      Me.rbTheirWheat.Location = New System.Drawing.Point(124, 20)
      Me.rbTheirWheat.Name = "rbTheirWheat"
      Me.rbTheirWheat.Size = New System.Drawing.Size(57, 17)
      Me.rbTheirWheat.TabIndex = 2
      Me.rbTheirWheat.TabStop = True
      Me.rbTheirWheat.Text = "Wheat"
      Me.rbTheirWheat.UseVisualStyleBackColor = True
      '
      'rbTheirWood
      '
      Me.rbTheirWood.AutoSize = True
      Me.rbTheirWood.Location = New System.Drawing.Point(64, 20)
      Me.rbTheirWood.Name = "rbTheirWood"
      Me.rbTheirWood.Size = New System.Drawing.Size(54, 17)
      Me.rbTheirWood.TabIndex = 1
      Me.rbTheirWood.TabStop = True
      Me.rbTheirWood.Text = "Wood"
      Me.rbTheirWood.UseVisualStyleBackColor = True
      '
      'rbTheirOre
      '
      Me.rbTheirOre.AutoSize = True
      Me.rbTheirOre.Checked = True
      Me.rbTheirOre.Location = New System.Drawing.Point(16, 20)
      Me.rbTheirOre.Name = "rbTheirOre"
      Me.rbTheirOre.Size = New System.Drawing.Size(42, 17)
      Me.rbTheirOre.TabIndex = 0
      Me.rbTheirOre.TabStop = True
      Me.rbTheirOre.Text = "Ore"
      Me.rbTheirOre.UseVisualStyleBackColor = True
      '
      'gbYours
      '
      Me.gbYours.BackColor = System.Drawing.Color.Transparent
      Me.gbYours.Controls.Add(Me.Label2)
      Me.gbYours.Controls.Add(Me.txtQuantity)
      Me.gbYours.Controls.Add(Me.rbOre)
      Me.gbYours.Controls.Add(Me.rbWheat)
      Me.gbYours.Controls.Add(Me.rbClay)
      Me.gbYours.Controls.Add(Me.rbWool)
      Me.gbYours.Controls.Add(Me.rbWood)
      Me.gbYours.Location = New System.Drawing.Point(3, 21)
      Me.gbYours.Name = "gbYours"
      Me.gbYours.Size = New System.Drawing.Size(316, 100)
      Me.gbYours.TabIndex = 10
      Me.gbYours.TabStop = False
      Me.gbYours.Text = "Your Recource"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(89, 66)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(49, 13)
      Me.Label2.TabIndex = 7
      Me.Label2.Text = "Quantity:"
      '
      'txtQuantity
      '
      Me.txtQuantity.Enabled = False
      Me.txtQuantity.Location = New System.Drawing.Point(144, 63)
      Me.txtQuantity.Name = "txtQuantity"
      Me.txtQuantity.Size = New System.Drawing.Size(62, 20)
      Me.txtQuantity.TabIndex = 6
      Me.txtQuantity.Text = "4"
      '
      'rbOre
      '
      Me.rbOre.AutoSize = True
      Me.rbOre.Checked = True
      Me.rbOre.Location = New System.Drawing.Point(17, 24)
      Me.rbOre.Name = "rbOre"
      Me.rbOre.Size = New System.Drawing.Size(42, 17)
      Me.rbOre.TabIndex = 1
      Me.rbOre.TabStop = True
      Me.rbOre.Text = "Ore"
      Me.rbOre.UseVisualStyleBackColor = True
      '
      'rbWheat
      '
      Me.rbWheat.AutoSize = True
      Me.rbWheat.Location = New System.Drawing.Point(125, 24)
      Me.rbWheat.Name = "rbWheat"
      Me.rbWheat.Size = New System.Drawing.Size(57, 17)
      Me.rbWheat.TabIndex = 5
      Me.rbWheat.TabStop = True
      Me.rbWheat.Text = "Wheat"
      Me.rbWheat.UseVisualStyleBackColor = True
      '
      'rbClay
      '
      Me.rbClay.AutoSize = True
      Me.rbClay.Location = New System.Drawing.Point(253, 24)
      Me.rbClay.Name = "rbClay"
      Me.rbClay.Size = New System.Drawing.Size(45, 17)
      Me.rbClay.TabIndex = 2
      Me.rbClay.TabStop = True
      Me.rbClay.Text = "Clay"
      Me.rbClay.UseVisualStyleBackColor = True
      '
      'rbWool
      '
      Me.rbWool.AutoSize = True
      Me.rbWool.Location = New System.Drawing.Point(193, 24)
      Me.rbWool.Name = "rbWool"
      Me.rbWool.Size = New System.Drawing.Size(50, 17)
      Me.rbWool.TabIndex = 4
      Me.rbWool.TabStop = True
      Me.rbWool.Text = "Wool"
      Me.rbWool.UseVisualStyleBackColor = True
      '
      'rbWood
      '
      Me.rbWood.AutoSize = True
      Me.rbWood.Location = New System.Drawing.Point(65, 24)
      Me.rbWood.Name = "rbWood"
      Me.rbWood.Size = New System.Drawing.Size(54, 17)
      Me.rbWood.TabIndex = 3
      Me.rbWood.TabStop = True
      Me.rbWood.Text = "Wood"
      Me.rbWood.UseVisualStyleBackColor = True
      '
      'TradeProposalWithBankForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.ActiveCaption
      Me.BackgroundImage = Global.Pioneers_of_Tacan.My.Resources.Resources.shitty_background
      Me.ClientSize = New System.Drawing.Size(322, 290)
      Me.ControlBox = False
      Me.Controls.Add(Me.btnCancel)
      Me.Controls.Add(Me.btnSend)
      Me.Controls.Add(Me.gbTheirs)
      Me.Controls.Add(Me.gbYours)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
      Me.Name = "TradeProposalWithBankForm"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Trade Proposal WIth Bank"
      Me.gbTheirs.ResumeLayout(False)
      Me.gbTheirs.PerformLayout()
      Me.gbYours.ResumeLayout(False)
      Me.gbYours.PerformLayout()
      Me.ResumeLayout(False)

   End Sub

   Friend WithEvents btnCancel As Button
   Friend WithEvents btnSend As Button
   Friend WithEvents gbTheirs As GroupBox
   Friend WithEvents Label1 As Label
   Friend WithEvents txtTheirQuantity As TextBox
   Friend WithEvents rbTheirClay As RadioButton
   Friend WithEvents rbTheirWool As RadioButton
   Friend WithEvents rbTheirWheat As RadioButton
   Friend WithEvents rbTheirWood As RadioButton
   Friend WithEvents rbTheirOre As RadioButton
   Friend WithEvents gbYours As GroupBox
   Friend WithEvents Label2 As Label
   Friend WithEvents txtQuantity As TextBox
   Friend WithEvents rbOre As RadioButton
   Friend WithEvents rbWheat As RadioButton
   Friend WithEvents rbClay As RadioButton
   Friend WithEvents rbWool As RadioButton
   Friend WithEvents rbWood As RadioButton
End Class
