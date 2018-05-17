Public Class ClientForm
    Private Const BOARDPAD = 18
    Private Const ROW_DISTANCE_SM = 37
    Private Const BOARD_UNITS_Y = 123
    Private Const BOARD_UNITS_X = 11
    Private Const Y_DIV_SMALL = 8
    Private Const Y_DIV_LARGE = 15

    Private Sub ClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Dim picBoxes = Me.Controls.OfType(Of Button)()
        For Each pic In picBoxes
            AddHandler pic.MouseEnter, AddressOf Button_MouseEnter
            AddHandler pic.MouseLeave, AddressOf Button_MouseLeave
            AddHandler pic.Click, AddressOf Button_Click
        Next
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        Dim pic = CType(sender, Button)
        pic.ImageIndex = 1
        RemoveHandler pic.MouseEnter, AddressOf Button_MouseEnter
        RemoveHandler pic.MouseLeave, AddressOf Button_MouseLeave
        RemoveHandler pic.Click, AddressOf Button_Click
    End Sub

    Private Sub Button_MouseEnter(sender As Object, e As EventArgs)
        Dim pic = CType(sender, Button)
        pic.ImageIndex = 1
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs)
        Dim pic = CType(sender, Button)
        pic.ImageIndex = 0
    End Sub
End Class
