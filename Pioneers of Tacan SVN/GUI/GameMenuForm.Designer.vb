<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameMenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameMenuForm))
        Me.btnMain = New System.Windows.Forms.Button()
        Me.btnDesktop = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMain
        '
        Me.btnMain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMain.BackColor = System.Drawing.Color.Transparent
        Me.btnMain.FlatAppearance.BorderSize = 0
        Me.btnMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMain.Font = New System.Drawing.Font("Manaspace", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMain.Location = New System.Drawing.Point(557, 488)
        Me.btnMain.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(328, 111)
        Me.btnMain.TabIndex = 2
        Me.btnMain.Text = "Quit To Main Menu"
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'btnDesktop
        '
        Me.btnDesktop.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDesktop.BackColor = System.Drawing.Color.Transparent
        Me.btnDesktop.FlatAppearance.BorderSize = 0
        Me.btnDesktop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDesktop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDesktop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDesktop.Font = New System.Drawing.Font("Manaspace", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesktop.Location = New System.Drawing.Point(557, 325)
        Me.btnDesktop.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDesktop.Name = "btnDesktop"
        Me.btnDesktop.Size = New System.Drawing.Size(328, 111)
        Me.btnDesktop.TabIndex = 1
        Me.btnDesktop.Text = "Quit To Desktop"
        Me.btnDesktop.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Manaspace", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(557, 162)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(328, 111)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'GameMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1443, 761)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDesktop)
        Me.Controls.Add(Me.btnMain)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "GameMenuForm"
        Me.Text = "GameMenuForm"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMain As Button
    Friend WithEvents btnDesktop As Button
    Friend WithEvents btnBack As Button
End Class
