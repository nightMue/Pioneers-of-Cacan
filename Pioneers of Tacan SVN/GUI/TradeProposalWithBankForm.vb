Public Class TradeProposalWithBankForm
   Private _mainForm As ParentForm
   Private psender As Player

   Public Sub New(main As ParentForm)

      ' This call is required by the designer.
      InitializeComponent()
      SetStyle(ControlStyles.SupportsTransparentBackColor, True)
      BackColor = Color.Transparent
      ' Add any initialization after the InitializeComponent() call.
      _mainForm = main
      psender = _mainForm.localPlayer
   End Sub

   Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
      Me.Hide()
      MessageBox.Show("Your trade has been accepted!")
      proccessTrade()
   End Sub

   Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
      Me.Hide()
   End Sub

   Private Sub proccessTrade()
      If rbClay.Checked Then
         psender.Clay -= Integer.Parse(txtQuantity.Text)
      ElseIf rbOre.Checked Then
         psender.Ore -= Integer.Parse(txtQuantity.Text)
      ElseIf rbWood.Checked Then
         psender.Wood -= Integer.Parse(txtQuantity.Text)
      ElseIf rbWheat.Checked Then
         psender.Wheat -= Integer.Parse(txtQuantity.Text)
      ElseIf rbWool.Checked Then
         psender.Wool -= Integer.Parse(txtQuantity.Text)
      End If

      If rbTheirClay.Checked Then
         psender.Clay += Integer.Parse(txtTheirQuantity.Text)
      ElseIf rbTheirOre.Checked Then
         psender.Ore += Integer.Parse(txtTheirQuantity.Text)
      ElseIf rbTheirWood.Checked Then
         psender.Wood += Integer.Parse(txtTheirQuantity.Text)
      ElseIf rbTheirWheat.Checked Then
         psender.Wheat += Integer.Parse(txtTheirQuantity.Text)
      ElseIf rbTheirWool.Checked Then
         psender.Wool += Integer.Parse(txtTheirQuantity.Text)
      End If

      _mainForm.Control.lblClayCount.Text = psender.Clay.ToString
      _mainForm.Control.lblWoodCount.Text = psender.Wood.ToString
      _mainForm.Control.lblWoolCount.Text = psender.Wool.ToString
      _mainForm.Control.lblWheatCount.Text = psender.Wheat.ToString
      _mainForm.Control.lblOreCount.Text = psender.Ore.ToString
   End Sub
End Class