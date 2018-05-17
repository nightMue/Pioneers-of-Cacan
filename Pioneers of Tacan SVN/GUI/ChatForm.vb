Imports System.Text.RegularExpressions
Imports Pioneers_of_Tacan.gameboard

Public Class ChatForm
   Private Const MAX_MSG_SIZE = 200

   Private Delegate Sub ChatDelegate(msg As String)

   Private _sendMessage As ChatDelegate = AddressOf PostChat

   Private open As Boolean = True

   Private Const OPEN_WIDTH As Integer = 300

   Private allControls = Me.Controls

   Private _mainForm As ParentForm

   Public Sub New(main As ParentForm)

      ' This call is required by the designer.
      InitializeComponent()

      ' Add any initialization after the InitializeComponent() call.
      SetStyle(ControlStyles.SupportsTransparentBackColor, True)
      BackColor = Color.Transparent

   End Sub

   Public Sub PostChat(msg As String)
      If (ChatLog.InvokeRequired) Then
         ChatLog.Invoke(_sendMessage, msg)
      Else
         Dim msgToken As String() = Regex.Split(msg, "|")
         Dim pColor As Color = parseColor(msgToken(0))
         ChatLog.SelectionColor = pColor
         ChatLog.AppendText(msgToken(1) & vbCrLf)
         ChatLog.ScrollToCaret()
      End If
   End Sub

   Private Sub btnChat_Click(sender As Object, e As EventArgs) Handles btnChat.Click
      Dim msg = txtChat.Text.Trim()
      If Not (msg = "") Then
         _mainForm.localPlayer.SendChat(msg)
      End If
   End Sub

   Private Sub Button2_Click(sender As Object, e As EventArgs)
      'SendMessage(New Player(Color.Blue), "TEST")
   End Sub

   Private Sub Button3_Click(sender As Object, e As EventArgs)
      'SendMessage(New Player(Color.Orange), "TEST")
   End Sub

   Private Sub Button4_Click(sender As Object, e As EventArgs)
      'SendMessage(New Player(Color.Green), "TEST")
   End Sub

   Private Sub txtChat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtChat.KeyPress
      If (txtChat.Text.Length > MAX_MSG_SIZE) Then
         e.Handled = True
      End If
   End Sub

   Private Function parseColor(c As String) As Color
      If (c = "re") Then
         Return Color.Red
      ElseIf (c = "bl") Then
         Return Color.Blue
      ElseIf (c = "wh") Then
         Return Color.White
      ElseIf (c = "or") Then
         Return Color.Orange
      ElseIf (c = "gr") Then
         Return Color.Green
      ElseIf (c = "br") Then
         Return Color.Brown
      Else
         Throw New Exception("Could not parse color.")
      End If
   End Function
End Class