Imports TicTocToeGame.Stores
Public Class Form1



    Public Property FirstPlayer As String
    Public Property SecondPlayer As String

    Private Sub Start_btn_Click(sender As Object, e As EventArgs) Handles Start_btn.Click
        player1 = FirstPlayerName.Text
        player2 = SecondPlayerName.Text
        Me.Hide()
        GamePage.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
End Class