Imports System.Drawing.Imaging

Public Class ParentForm
   Public WithEvents Board As BoardForm
   Public WithEvents Chat As ChatForm
   Public WithEvents Control As ControlForm
   Public WithEvents Deck As DeckForm
   Private WithEvents GameMenu As GameMenuForm
   Public WithEvents localPlayer As Player
   Public mainClass As mainClass

   Public DevelopmentCards As New ArrayList

   Public Sub New(local As Player)
      'Public Sub New()

      ' This call is required by the designer.
      InitializeComponent()

      ' Add any initialization after the InitializeComponent() call.
      localPlayer = local
      mainClass = New mainClass
      localPlayer = mainClass.getPlayerOne
   End Sub

   Private Sub ParentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackgroundImageLayout = ImageLayout.Stretch
        Me.WindowState = FormWindowState.Maximized

      'run once on load of form
      SetupDecks()

      Chat = New ChatForm(Me) With {
            .Owner = Me,
            .MdiParent = Me,
            .Dock = DockStyle.Left
        }

      Control = New ControlForm(Me) With {
            .Owner = Me,
            .MdiParent = Me,
            .Dock = DockStyle.Right
        }

      Deck = New DeckForm(Me) With {
            .Owner = Me,
            .MdiParent = Me,
            .Dock = DockStyle.Bottom
      }

      Board = New BoardForm With {
            .Owner = Me,
            .MdiParent = Me,
            .StartPosition = FormStartPosition.CenterScreen,
            .playerColor = localPlayer.PlayerNum
        }

      GameMenu = New GameMenuForm(Me) With {
            .Owner = Me,
            .MdiParent = Me,
            .Dock = DockStyle.Fill,
            .FormBorderStyle = FormBorderStyle.None}
      '.MainForm = Me


      Board.Show()
      Chat.Show()
      Control.Show()
      Deck.Show()
      Chat.BringToFront()
      Control.BringToFront()
   End Sub

    Private Sub ParentForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            If Not (GameMenu.Visible = True) Then
                GameMenu.Show()
                Chat.Dock = DockStyle.None
            Else
                GameMenu.Hide()
                Chat.Dock = DockStyle.Left
            End If
        End If
    End Sub

   Private Sub GameMenu_VisibleChanged(sender As Object, e As EventArgs) Handles GameMenu.VisibleChanged
      If (GameMenu.Visible = True) Then
         Chat.Dock = DockStyle.None
         Control.Dock = DockStyle.None
         Deck.Dock = DockStyle.None
      Else
         Chat.Dock = DockStyle.Left
         Control.Dock = DockStyle.Right
         Deck.Dock = DockStyle.Bottom
      End If
   End Sub

   Friend Sub QuitToMenu()
      Me.Hide()
      StartForm.Show()
   End Sub

   Private Sub SetupDecks()
      'setup DevelompentCards
      For value As Integer = 1 To 14
         DevelopmentCards.Add(New Knight)
      Next
      For value As Integer = 1 To 5
         DevelopmentCards.Add(New VP)
      Next
      DevelopmentCards.Add(New RoadBuilding)
      DevelopmentCards.Add(New RoadBuilding)
      DevelopmentCards.Add(New Monopoly)
      DevelopmentCards.Add(New Monopoly)
      DevelopmentCards.Add(New Discovery)
      DevelopmentCards.Add(New Discovery)
   End Sub

End Class