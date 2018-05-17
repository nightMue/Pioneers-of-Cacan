Public Class TradeProposalWithPlayerForm
   Private _mainForm As ParentForm
   Private proposal As Boolean
   Private psender As Player
   Public Sub New(main As ParentForm)

      ' This call is required by the designer.
      InitializeComponent()
      SetStyle(ControlStyles.SupportsTransparentBackColor, True)
      BackColor = Color.Transparent

      ' Add any initialization after the InitializeComponent() call.
      _mainForm = main
   End Sub

   Public Sub setProposal(senderPlayer As Player)
      proposal = True
      psender = senderPlayer
      setState()
   End Sub

   Public Sub setInvitation()
      proposal = False
      setState()
   End Sub

   Private Sub setState()
      If proposal Then
         gbYours.Enabled = True
         gbTheirs.Enabled = True
         btnSend.Text = "Send"
         btnCancel.Text = "Cancel"
         Me.Text = "Trade Proposal With Player"
      Else
         gbYours.Enabled = False
         gbTheirs.Enabled = False
         btnSend.Text = "Accept"
         btnCancel.Text = "Decline"
         Me.Text = "Trade Proposal with " + psender.Nickname
      End If
   End Sub

   Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
      If proposal Then
         If (rbClay.Checked Or rbOre.Checked Or rbWheat.Checked Or rbWood.Checked Or rbWool.Checked) And Not txtQuantity.Text = "" Then
            If (rbTheirClay.Checked Or rbTheirOre.Checked Or rbTheirWheat.Checked Or rbTheirWood.Checked Or rbTheirWool.Checked) And Not txtTheirQuantity.Text = "" Then
               ' send back to server to send proposal to all players
               If checkRecources() = True Then
                  sendInvitation()
               Else
                  MessageBox.Show("Your quantities are not suitable to yours or the others recources!")
               End If
            Else
               MessageBox.Show("Please fill out all fields!")
            End If
         Else
            MessageBox.Show("Please fill out all fields!")
         End If
      Else
         ' send back to server and sender that proposal was declined or accepted
         Me.Hide()
         MessageBox.Show("Your trade has been accepted!")
         processTrade()
         clearFeilds()
      End If
   End Sub

   Private Sub sendInvitation()
      Me.Hide()
      setInvitation()
      setState()
      Me.Show()
      Me.BringToFront()
   End Sub

   Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
      If proposal Then
         Me.Hide()
      Else
         Me.Hide()
         MessageBox.Show("Your trade has been declined!")
         clearFeilds()
      End If
   End Sub

   Private Sub clearFeilds()
      rbOre.Checked = True
      rbTheirOre.Checked = True
      txtQuantity.Text = ""
      txtTheirQuantity.Text = ""
   End Sub

   Private Sub processTrade()
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

   Private Function checkRecources() As Boolean
      Dim sender As Boolean = False
      Dim reciver As Boolean = False
      If rbClay.Checked Then
         If psender.Clay >= Integer.Parse(txtQuantity.Text) Then
            sender = True
         Else
            sender = False
         End If
      ElseIf rbOre.Checked Then
         If psender.Ore >= Integer.Parse(txtQuantity.Text) Then
            sender = True
         Else
            sender = False
         End If
      ElseIf rbWood.Checked Then
         If psender.Wood >= Integer.Parse(txtQuantity.Text) Then
            sender = True
         Else
            sender = False
         End If
      ElseIf rbWheat.Checked Then
         If psender.Wheat >= Integer.Parse(txtQuantity.Text) Then
            sender = True
         Else
            sender = False
         End If
      ElseIf rbWool.Checked Then
         If psender.Wool >= Integer.Parse(txtQuantity.Text) Then
            sender = True
         Else
            sender = False
         End If
      End If

      If Integer.Parse(txtTheirQuantity.Text) <= 10 Then
         reciver = True
      Else
         reciver = False
      End If

      If sender And reciver Then
         Return True
      Else
         Return False
      End If
   End Function
End Class