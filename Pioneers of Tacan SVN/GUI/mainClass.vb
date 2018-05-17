Imports System.Net.Sockets

Public Class mainClass
   Private playerOne As Player
   Private playerTwo As Player
   'Private tcp1 As TcpClient = New TcpClient
   'Private tcp2 As TcpClient = New TcpClient

   Public Sub New()
      playerOne = New Player("Player One", Color.Blue, 1)
      playerTwo = New Player("Player Two", Color.Red, 2)
   End Sub

   Public Function getPlayerOne() As Player
      Return playerOne
   End Function

   Public Function getPlayerTwo() As Player
      Return playerTwo
   End Function

End Class
