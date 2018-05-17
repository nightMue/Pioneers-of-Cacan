Public Class DiscoveryPlayForm
   Public Property player As Player
   Public Property _mainForm As ParentForm

   Public Sub New()

      ' This call is required by the designer.
      InitializeComponent()
      SetStyle(ControlStyles.SupportsTransparentBackColor, True)
      BackColor = Color.Transparent
   End Sub

   Private Sub btnOre_Click(sender As Object, e As EventArgs) Handles btnOre.Click
      player.Ore += 2
      MessageBox.Show("You received 2 Ore from the bank!" + vbCrLf + "You now have " + player.Ore.ToString + " ore.")
      _mainForm.Control.lblOreCount.Text = player.Ore.ToString
      Me.Hide()
   End Sub

   Private Sub btnClay_Click(sender As Object, e As EventArgs) Handles btnClay.Click
      player.Clay += 2
      MessageBox.Show("You received 2 Clay from the bank!" + vbCrLf + "You now have " + player.Clay.ToString + " clay.")
      _mainForm.Control.lblClayCount.Text = player.Clay.ToString
      Me.Hide()
   End Sub

   Private Sub btnWool_Click(sender As Object, e As EventArgs) Handles btnWool.Click
      player.Wool += 2
      MessageBox.Show("You received 2 Wool from the bank!" + vbCrLf + "You now have " + player.Wool.ToString + " wool.")
      _mainForm.Control.lblWoolCount.Text = player.Wool.ToString
      Me.Hide()
   End Sub

   Private Sub btnWood_Click(sender As Object, e As EventArgs) Handles btnWood.Click
      player.Wood += 2
      MessageBox.Show("You received 2 Wood from the bank!" + vbCrLf + "You now have " + player.Wood.ToString + " wood.")
      _mainForm.Control.lblWoodCount.Text = player.Wood.ToString
      Me.Hide()
   End Sub

   Private Sub btnWheat_Click(sender As Object, e As EventArgs) Handles btnWheat.Click
      player.Wheat += 2
      MessageBox.Show("You received 2 Wheat from the bank!" + vbCrLf + "You now have " + player.Wheat.ToString + " wheat.")
      _mainForm.Control.lblWheatCount.Text = player.Wheat.ToString
      Me.Hide()
   End Sub
End Class