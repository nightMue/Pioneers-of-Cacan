Public Class BoardForm
   Private buttons As List(Of Button)
   Public Property playerColor As Integer
   Private placingCity = False

   Public Sub New()

      ' This call is required by the designer.
      InitializeComponent()

      ' Add any initialization after the InitializeComponent() call.
      SetStyle(ControlStyles.SupportsTransparentBackColor, True)
      BackColor = Color.Transparent
   End Sub

   Private Sub BoardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      buttons = (Me.Controls.OfType(Of Button)()).ToList
      'buttons.Sort(Function(elementA As Button, elementB As Button)
      '                Return (elementA.Name).CompareTo(elementB.Name)
      '             End Function)
      For Each btn In buttons
         btn.ImageIndex = 0
      Next
   End Sub

   Private Sub Button_Click(sender As Object, e As EventArgs)
      Dim btn = CType(sender, Button)
      If (placingCity) Then
         btn.Size = New Size(60, 60)
      End If
      btn.ImageIndex = playerColor
      Me.Select()
      disablePlaceSettlements()
      If (placingCity) Then
         playerColor -= 6
         placingCity = False
      End If
   End Sub

   Private Sub Button_MouseEnter(sender As Object, e As EventArgs)
      Dim pic = CType(sender, Button)
      If (placingCity) Then
         pic.Size = New Size(60, 60)
      End If
      pic.ImageIndex = playerColor
   End Sub

   Private Sub Button_MouseLeave(sender As Object, e As EventArgs)
      Dim pic = CType(sender, Button)
      If (placingCity) Then
         pic.Size = New Size(50, 51)
      End If
      If placingCity Then
         pic.ImageIndex = playerColor - 6
      Else

         pic.ImageIndex = 0
      End If
   End Sub

   Public Sub enablePlaceSettlements()
      For Each b In buttons
         If (b.ImageIndex = 0) Then
            AddHandler b.MouseEnter, AddressOf Button_MouseEnter
            AddHandler b.MouseLeave, AddressOf Button_MouseLeave
            AddHandler b.Click, AddressOf Button_Click
         End If
      Next
   End Sub

   Public Sub disablePlaceSettlements()
      For Each b In buttons
         RemoveHandler b.MouseEnter, AddressOf Button_MouseEnter
         RemoveHandler b.MouseLeave, AddressOf Button_MouseLeave
         RemoveHandler b.Click, AddressOf Button_Click
      Next
   End Sub

   Public Sub enablePlaceCity()
      placingCity = True
      playerColor += 6
      For Each b In buttons
         If (b.ImageIndex > 0 And b.ImageIndex < 7) Then
            AddHandler b.MouseEnter, AddressOf Button_MouseEnter
            AddHandler b.MouseLeave, AddressOf Button_MouseLeave
            AddHandler b.Click, AddressOf Button_Click
         End If
      Next
   End Sub
End Class
