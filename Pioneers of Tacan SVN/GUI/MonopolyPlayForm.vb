Public Class MonopolyPlayForm
   Public Property player As Player

   Public Sub New()

      ' This call is required by the designer.
      InitializeComponent()
      SetStyle(ControlStyles.SupportsTransparentBackColor, True)
      BackColor = Color.Transparent

   End Sub

   Private Sub btnOre_Click(sender As Object, e As EventArgs) Handles btnOre.Click
      '
      MessageBox.Show("You received X amount of Ore from everyone combined!" + vbCrLf + "You now have " + player.Ore.ToString + " ore.")
      Me.Hide()
   End Sub

   Private Sub btnClay_Click(sender As Object, e As EventArgs) Handles btnClay.Click
      '
      MessageBox.Show("You received X amount of Clay from everyone combined!" + vbCrLf + "You now have " + player.Clay.ToString + " clay.")
      Me.Hide()
   End Sub

   Private Sub btnWool_Click(sender As Object, e As EventArgs) Handles btnWool.Click
      '
      MessageBox.Show("You received X amount of Wool from everyone combined!" + vbCrLf + "You now have " + player.Wool.ToString + " wool.")
      Me.Hide()
   End Sub

   Private Sub btnWood_Click(sender As Object, e As EventArgs) Handles btnWood.Click
      '
      MessageBox.Show("You received X amount of Wood from everyone combined!" + vbCrLf + "You now have " + player.Wood.ToString + " wood.")
      Me.Hide()
   End Sub

   Private Sub btnWheat_Click(sender As Object, e As EventArgs) Handles btnWheat.Click
      '
      MessageBox.Show("You received X amount of Wheat from everyone combined!" + vbCrLf + "You now have " + player.Wheat.ToString + " wheat.")
      Me.Hide()
   End Sub
End Class