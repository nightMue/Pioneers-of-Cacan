Imports System.Net.Sockets
Imports Pioneers_of_Tacan.BoardPoint

Public Class Player

   Public Property Clay As Integer
   Public Property Ore As Integer
   Public Property Wheat As Integer
   Public Property Wood As Integer
   Public Property Wool As Integer
   Public ReadOnly Property PlayerColor As Color
   Public ReadOnly Property Nickname As String
   Public ReadOnly Property Client As TcpClient
   Public ReadOnly Property PlayerNum As Integer
   Friend Property LongestRoad As Integer
   Friend Property ArmySize As Integer

   Public DevelopmentCards As ArrayList

   Public Property KnightCount As Integer
   Public Property VPCount As Integer
   Public Property RoadBuildingCount As Integer
   Public Property MonopolyCount As Integer
   Public Property DiscoveryCount As Integer

   Public Property VictoryPoints As Integer

   Private buildings As List(Of Intersect)

   Private WithEvents serverHandler As ServerIO

   Private gameForm As ParentForm

   Public Property numSettlements As Integer = 0

   Public Sub New(name As String, c As Color, cl As TcpClient, num As Integer)
      PlayerColor = c
      Nickname = name
      Client = cl
      PlayerNum = num
      LongestRoad = 0
      ArmySize = 0
      serverHandler = New ServerIO(Client.GetStream())
      Clay = 10
      Ore = 10
      Wood = 10
      Wheat = 10
      Wool = 10
      KnightCount = 0
      VPCount = 0
      RoadBuildingCount = 0
      MonopolyCount = 0
      DiscoveryCount = 0
      VictoryPoints = 0
      DevelopmentCards = New ArrayList()
   End Sub

   Public Sub New(name As String, c As Color, num As Integer)
      PlayerColor = c
      Nickname = name
      PlayerNum = num
      LongestRoad = 0
      ArmySize = 0
      Clay = 10
      Ore = 10
      Wood = 10
      Wheat = 10
      Wool = 10
      KnightCount = 0
      VPCount = 0
      RoadBuildingCount = 0
      MonopolyCount = 0
      DiscoveryCount = 0
      VictoryPoints = 0
      DevelopmentCards = New ArrayList()
   End Sub

   Public Sub New(cl As TcpClient)
      Client = cl
      serverHandler = New ServerIO(Client.GetStream())
   End Sub

   Public Sub startGame()
      gameForm = New ParentForm(Me)
      gameForm.Show()
   End Sub

   Public Sub ChatReceived(msg As String) Handles serverHandler.ChatReceived
      gameForm.Chat.PostChat(msg)
   End Sub

   Public Sub SendChat(msg As String)
      serverHandler.sendChat(msg)
   End Sub

   Public Sub SendRoll(roll As Integer)
      serverHandler.sendRoll(roll)
   End Sub

   Private Function getColorHeader() As String
      Return PlayerColor.ToString().Substring(0, 2) & "|"
   End Function

   Public Sub CollectResources(rollValue As Integer)
      Dim resourcesCollected() As Integer = {0, 0, 0, 0, 0}

      For Each i As Intersect In buildings
         i.CollectResources(rollValue, resourcesCollected)
      Next

      Dim collectedStr As String =
         "Resources Collected:" & vbCrLf &
         "    Clay:  " & resourcesCollected(0) & vbCrLf &
         "    Ore:   " & resourcesCollected(1) & vbCrLf &
         "    Wheat: " & resourcesCollected(2) & vbCrLf &
         "    Wood:  " & resourcesCollected(3) & vbCrLf &
         "    Wool:  " & resourcesCollected(4)

      MessageBox.Show(collectedStr)

      Clay += resourcesCollected(0)
      Ore += resourcesCollected(1)
      Wheat += resourcesCollected(2)
      Wood += resourcesCollected(3)
      Wool += resourcesCollected(4)
   End Sub
End Class
