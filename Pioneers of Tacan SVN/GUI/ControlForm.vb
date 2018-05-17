Public Class ControlForm
   Private _mainForm As ParentForm
   Private useCardForm As UseCard
   Private buildForm As BuyForm
   Private tradePlayerForm As TradeProposalWithPlayerForm
   Private tradeBankForm As TradeProposalWithBankForm

   Public Sub New(main As ParentForm)

      ' This call is required by the designer.
      InitializeComponent()

      ' Add any initialization after the InitializeComponent() call.

      SetStyle(ControlStyles.SupportsTransparentBackColor, True)
      BackColor = Color.Transparent
      _mainForm = main
      useCardForm = New UseCard(_mainForm)
      buildForm = New BuyForm(_mainForm)
      tradePlayerForm = New TradeProposalWithPlayerForm(_mainForm)
      tradeBankForm = New TradeProposalWithBankForm(_mainForm)
   End Sub
   Private Sub TabPage1_Click(sender As Object, e As EventArgs)

   End Sub

   Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
      Dim Generator As System.Random = New System.Random()

      Dim d1 As Integer = Generator.Next(1, 7)
      Dim d2 As Integer = Generator.Next(1, 7)
      Dim total As Integer = d1 + d2
      MessageBox.Show("You rolled a " + total.ToString)

      _mainForm.localPlayer.SendRoll(total)

   End Sub

   Private Sub btnBuild_Click(sender As Object, e As EventArgs) Handles btnBuild.Click
      useCardForm.Hide()
      buildForm.Show()
      buildForm.BringToFront()
   End Sub

   Private Sub btnUserDevelopmentCard_Click(sender As Object, e As EventArgs) Handles btnUserDevelopmentCard.Click
      buildForm.Hide()
      useCardForm.Show()
      useCardForm.BringToFront()
   End Sub

   Private Sub ControlForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      SetLabels()
   End Sub

   Public Sub SetLabels()
      lblClayCount.Text = _mainForm.localPlayer.Clay.ToString
      lblOreCount.Text = _mainForm.localPlayer.Ore.ToString
      lblWoodCount.Text = _mainForm.localPlayer.Wood.ToString
      lblWoolCount.Text = _mainForm.localPlayer.Wool.ToString
      lblWheatCount.Text = _mainForm.localPlayer.Wheat.ToString
      lblPlayerName.Text = _mainForm.localPlayer.Nickname.ToString
   End Sub

   Private Sub btnEndTurn_Click(sender As Object, e As EventArgs) Handles btnEndTurn.Click
      If _mainForm.localPlayer.Nickname = "Player One" Then
         _mainForm.localPlayer = _mainForm.mainClass.getPlayerTwo
      Else
         _mainForm.localPlayer = _mainForm.mainClass.getPlayerOne
      End If
      _mainForm.Deck.reload()
      _mainForm.Control.SetLabels()
      _mainForm.Board.playerColor = _mainForm.localPlayer.PlayerNum
   End Sub

   Private Sub btnTradePlayer_Click(sender As Object, e As EventArgs) Handles btnTradePlayer.Click
      tradePlayerForm.setProposal(_mainForm.localPlayer)
      tradePlayerForm.Show()
      tradePlayerForm.BringToFront()
   End Sub

   Private Sub btnTradeBank_Click(sender As Object, e As EventArgs) Handles btnTradeBank.Click
      tradeBankForm.Show()
      tradeBankForm.BringToFront()
   End Sub
End Class