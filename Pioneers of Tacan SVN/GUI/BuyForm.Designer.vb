<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuyForm
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
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.Label7 = New System.Windows.Forms.Label()
      Me.Label8 = New System.Windows.Forms.Label()
      Me.Label9 = New System.Windows.Forms.Label()
      Me.lblOre = New System.Windows.Forms.Label()
      Me.lblWood = New System.Windows.Forms.Label()
      Me.lblWheat = New System.Windows.Forms.Label()
      Me.lblWool = New System.Windows.Forms.Label()
      Me.lblClay = New System.Windows.Forms.Label()
      Me.btnRoad = New System.Windows.Forms.Button()
      Me.btnDevelopmentCard = New System.Windows.Forms.Button()
      Me.btnCity = New System.Windows.Forms.Button()
      Me.btnSettlement = New System.Windows.Forms.Button()
      Me.btnCancel = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Location = New System.Drawing.Point(13, 72)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(147, 13)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "road = 1 clay, 1 wood : +0 VP"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Location = New System.Drawing.Point(13, 121)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(255, 13)
      Me.Label2.TabIndex = 1
      Me.Label2.Text = "settlement = 1 clay, 1 wood, 1 wheat, 1 wool : +1 VP"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Location = New System.Drawing.Point(13, 170)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(141, 13)
      Me.Label3.TabIndex = 2
      Me.Label3.Text = "city = 2 wheat, 3 ore : +2 VP"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Location = New System.Drawing.Point(13, 219)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(241, 13)
      Me.Label4.TabIndex = 3
      Me.Label4.Text = "development card = 1 wool, 1 wheat, 1 ore : ? VP"
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(31, 24)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(31, 13)
      Me.Label5.TabIndex = 4
      Me.Label5.Text = "Ore:"
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(321, 24)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(35, 13)
      Me.Label6.TabIndex = 5
      Me.Label6.Text = "Clay:"
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(248, 24)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(40, 13)
      Me.Label7.TabIndex = 6
      Me.Label7.Text = "Wool:"
      '
      'Label8
      '
      Me.Label8.AutoSize = True
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(168, 24)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(48, 13)
      Me.Label8.TabIndex = 7
      Me.Label8.Text = "Wheat:"
      '
      'Label9
      '
      Me.Label9.AutoSize = True
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(96, 24)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(44, 13)
      Me.Label9.TabIndex = 8
      Me.Label9.Text = "Wood:"
      '
      'lblOre
      '
      Me.lblOre.AutoSize = True
      Me.lblOre.BackColor = System.Drawing.Color.Transparent
      Me.lblOre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblOre.Location = New System.Drawing.Point(65, 24)
      Me.lblOre.Name = "lblOre"
      Me.lblOre.Size = New System.Drawing.Size(14, 13)
      Me.lblOre.TabIndex = 9
      Me.lblOre.Text = "1"
      '
      'lblWood
      '
      Me.lblWood.AutoSize = True
      Me.lblWood.BackColor = System.Drawing.Color.Transparent
      Me.lblWood.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblWood.Location = New System.Drawing.Point(140, 24)
      Me.lblWood.Name = "lblWood"
      Me.lblWood.Size = New System.Drawing.Size(14, 13)
      Me.lblWood.TabIndex = 10
      Me.lblWood.Text = "1"
      '
      'lblWheat
      '
      Me.lblWheat.AutoSize = True
      Me.lblWheat.BackColor = System.Drawing.Color.Transparent
      Me.lblWheat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblWheat.Location = New System.Drawing.Point(216, 24)
      Me.lblWheat.Name = "lblWheat"
      Me.lblWheat.Size = New System.Drawing.Size(14, 13)
      Me.lblWheat.TabIndex = 11
      Me.lblWheat.Text = "1"
      '
      'lblWool
      '
      Me.lblWool.AutoSize = True
      Me.lblWool.BackColor = System.Drawing.Color.Transparent
      Me.lblWool.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblWool.Location = New System.Drawing.Point(287, 24)
      Me.lblWool.Name = "lblWool"
      Me.lblWool.Size = New System.Drawing.Size(14, 13)
      Me.lblWool.TabIndex = 12
      Me.lblWool.Text = "1"
      '
      'lblClay
      '
      Me.lblClay.AutoSize = True
      Me.lblClay.BackColor = System.Drawing.Color.Transparent
      Me.lblClay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblClay.Location = New System.Drawing.Point(357, 24)
      Me.lblClay.Name = "lblClay"
      Me.lblClay.Size = New System.Drawing.Size(14, 13)
      Me.lblClay.TabIndex = 13
      Me.lblClay.Text = "1"
      '
      'btnRoad
      '
      Me.btnRoad.Location = New System.Drawing.Point(286, 67)
      Me.btnRoad.Name = "btnRoad"
      Me.btnRoad.Size = New System.Drawing.Size(125, 23)
      Me.btnRoad.TabIndex = 14
      Me.btnRoad.Text = "Buy Road"
      Me.btnRoad.UseVisualStyleBackColor = True
      '
      'btnDevelopmentCard
      '
      Me.btnDevelopmentCard.Location = New System.Drawing.Point(286, 214)
      Me.btnDevelopmentCard.Name = "btnDevelopmentCard"
      Me.btnDevelopmentCard.Size = New System.Drawing.Size(125, 23)
      Me.btnDevelopmentCard.TabIndex = 15
      Me.btnDevelopmentCard.Text = "Buy Dvelopment Card"
      Me.btnDevelopmentCard.UseVisualStyleBackColor = True
      '
      'btnCity
      '
      Me.btnCity.Location = New System.Drawing.Point(286, 165)
      Me.btnCity.Name = "btnCity"
      Me.btnCity.Size = New System.Drawing.Size(125, 23)
      Me.btnCity.TabIndex = 16
      Me.btnCity.Text = "Buy City"
      Me.btnCity.UseVisualStyleBackColor = True
      '
      'btnSettlement
      '
      Me.btnSettlement.Location = New System.Drawing.Point(286, 116)
      Me.btnSettlement.Name = "btnSettlement"
      Me.btnSettlement.Size = New System.Drawing.Size(125, 23)
      Me.btnSettlement.TabIndex = 17
      Me.btnSettlement.Text = "Buy Settlement"
      Me.btnSettlement.UseVisualStyleBackColor = True
      '
      'btnCancel
      '
      Me.btnCancel.Location = New System.Drawing.Point(177, 250)
      Me.btnCancel.Name = "btnCancel"
      Me.btnCancel.Size = New System.Drawing.Size(75, 23)
      Me.btnCancel.TabIndex = 18
      Me.btnCancel.Text = "Cancel"
      Me.btnCancel.UseVisualStyleBackColor = True
      '
      'BuyForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.ActiveCaption
      Me.BackgroundImage = Global.Pioneers_of_Tacan.My.Resources.Resources.shitty_background
      Me.ClientSize = New System.Drawing.Size(428, 285)
      Me.ControlBox = False
      Me.Controls.Add(Me.btnCancel)
      Me.Controls.Add(Me.btnSettlement)
      Me.Controls.Add(Me.btnCity)
      Me.Controls.Add(Me.btnDevelopmentCard)
      Me.Controls.Add(Me.btnRoad)
      Me.Controls.Add(Me.lblClay)
      Me.Controls.Add(Me.lblWool)
      Me.Controls.Add(Me.lblWheat)
      Me.Controls.Add(Me.lblWood)
      Me.Controls.Add(Me.lblOre)
      Me.Controls.Add(Me.Label9)
      Me.Controls.Add(Me.Label8)
      Me.Controls.Add(Me.Label7)
      Me.Controls.Add(Me.Label6)
      Me.Controls.Add(Me.Label5)
      Me.Controls.Add(Me.Label4)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
      Me.Name = "BuyForm"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Build Options"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents Label1 As Label
   Friend WithEvents Label2 As Label
   Friend WithEvents Label3 As Label
   Friend WithEvents Label4 As Label
   Friend WithEvents Label5 As Label
   Friend WithEvents Label6 As Label
   Friend WithEvents Label7 As Label
   Friend WithEvents Label8 As Label
   Friend WithEvents Label9 As Label
   Friend WithEvents lblOre As Label
   Friend WithEvents lblWood As Label
   Friend WithEvents lblWheat As Label
   Friend WithEvents lblWool As Label
   Friend WithEvents lblClay As Label
   Friend WithEvents btnRoad As Button
   Friend WithEvents btnDevelopmentCard As Button
   Friend WithEvents btnCity As Button
   Friend WithEvents btnSettlement As Button
   Friend WithEvents btnCancel As Button
End Class
