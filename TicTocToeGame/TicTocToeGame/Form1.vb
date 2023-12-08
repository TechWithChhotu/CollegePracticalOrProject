Imports TicTocToeGame.Stores
Public Class GamePage
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Label1.Text = player1
        Label3.Text = player2
    End Sub

    Dim checkForXorO As Boolean = False
    Dim addOneToScore As Integer = 0

    Sub ButtonsEnabledFalse()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
    End Sub

    Sub CheckForWin()
        Dim tempScore As Integer = addOneToScore

        'Check win for player1
        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            Button1.BackColor = Color.Green
            Button2.BackColor = Color.Green
            Button3.BackColor = Color.Green
            MessageBox.Show("Winner is " + player1, "Tic-Toc-Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(PlayerA.Text)
            PlayerA.Text = Convert.ToString(addOneToScore + 1)
            ButtonsEnabledFalse()
        End If

        If Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            Button4.BackColor = Color.Green
            Button5.BackColor = Color.Green
            Button6.BackColor = Color.Green
            MessageBox.Show("Winner is " + player1, "Tic-Toc-Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(PlayerA.Text)
            PlayerA.Text = Convert.ToString(addOneToScore + 1)
            ButtonsEnabledFalse()
        End If

        If Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            Button7.BackColor = Color.Green
            Button8.BackColor = Color.Green
            Button9.BackColor = Color.Green
            MessageBox.Show("Winner is " + player1, "Tic-Toc-Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(PlayerA.Text)
            PlayerA.Text = Convert.ToString(addOneToScore + 1)
            ButtonsEnabledFalse()
        End If

        If Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            Button1.BackColor = Color.Green
            Button4.BackColor = Color.Green
            Button7.BackColor = Color.Green
            MessageBox.Show("Winner is " + player1, "Tic-Toc-Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(PlayerA.Text)
            PlayerA.Text = Convert.ToString(addOneToScore + 1)
            ButtonsEnabledFalse()
        End If

        If Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
            Button2.BackColor = Color.Green
            Button5.BackColor = Color.Green
            Button8.BackColor = Color.Green
            MessageBox.Show("Winner is " + player1, "Tic-Toc-Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(PlayerA.Text)
            PlayerA.Text = Convert.ToString(addOneToScore + 1)
            ButtonsEnabledFalse()
        End If

        If Button9.Text = "X" And Button6.Text = "X" And Button3.Text = "X" Then
            Button9.BackColor = Color.Green
            Button6.BackColor = Color.Green
            Button3.BackColor = Color.Green
            MessageBox.Show("Winner is " + player1, "Tic-Toc-Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(PlayerA.Text)
            PlayerA.Text = Convert.ToString(addOneToScore + 1)
            ButtonsEnabledFalse()
        End If
        If Button7.Text = "X" And Button5.Text = "X" And Button3.Text = "X" Then
            Button7.BackColor = Color.Green
            Button5.BackColor = Color.Green
            Button3.BackColor = Color.Green
            MessageBox.Show("Winner is " + player1, "Tic-Toc-Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(PlayerA.Text)
            PlayerA.Text = Convert.ToString(addOneToScore + 1)
            ButtonsEnabledFalse()
        End If

        If Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            Button1.BackColor = Color.Green
            Button5.BackColor = Color.Green
            Button9.BackColor = Color.Green
            MessageBox.Show("Winner is " + player1, "Tic-Toc-Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(PlayerA.Text)
            PlayerA.Text = Convert.ToString(addOneToScore + 1)
            ButtonsEnabledFalse()
        End If
        'check win for player1 is complete


        'Check win for player2
        If Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then
            Button1.BackColor = Color.Green
            Button2.BackColor = Color.Green
            Button3.BackColor = Color.Green
            MessageBox.Show("Winner is " + player2, "Tic-Toc-Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(PlayerB.Text)
            PlayerB.Text = Convert.ToString(addOneToScore + 1)
            ButtonsEnabledFalse()
        End If

        If Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then
            Button4.BackColor = Color.Green
            Button5.BackColor = Color.Green
            Button6.BackColor = Color.Green
            MessageBox.Show("Winner is " + player2, "Tic-Toc-Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(PlayerB.Text)
            PlayerB.Text = Convert.ToString(addOneToScore + 1)
            ButtonsEnabledFalse()
        End If

        If Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then
            Button7.BackColor = Color.Green
            Button8.BackColor = Color.Green
            Button9.BackColor = Color.Green
            MessageBox.Show("Winner is " + player2, "Tic-Toc-Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(PlayerB.Text)
            PlayerB.Text = Convert.ToString(addOneToScore + 1)
            ButtonsEnabledFalse()
        End If

        If Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then
            Button1.BackColor = Color.Green
            Button4.BackColor = Color.Green
            Button7.BackColor = Color.Green
            MessageBox.Show("Winner is " + player2, "Tic-Toc-Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(PlayerB.Text)
            PlayerB.Text = Convert.ToString(addOneToScore + 1)
            ButtonsEnabledFalse()
        End If

        If Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then
            Button2.BackColor = Color.Green
            Button5.BackColor = Color.Green
            Button8.BackColor = Color.Green
            MessageBox.Show("Winner is " + player2, "Tic-Toc-Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(PlayerB.Text)
            PlayerB.Text = Convert.ToString(addOneToScore + 1)
            ButtonsEnabledFalse()
        End If

        If Button9.Text = "O" And Button6.Text = "O" And Button3.Text = "O" Then
            Button9.BackColor = Color.Green
            Button6.BackColor = Color.Green
            Button3.BackColor = Color.Green
            MessageBox.Show("Winner is " + player2, "Tic-Toc-Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(PlayerB.Text)
            PlayerB.Text = Convert.ToString(addOneToScore + 1)
            ButtonsEnabledFalse()
        End If

        If Button7.Text = "O" And Button5.Text = "O" And Button3.Text = "O" Then
            Button7.BackColor = Color.Green
            Button5.BackColor = Color.Green
            Button3.BackColor = Color.Green
            MessageBox.Show("Winner is " + player2, "Tic-Toc-Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(PlayerB.Text)
            PlayerB.Text = Convert.ToString(addOneToScore + 1)
            ButtonsEnabledFalse()
        End If

        If Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then
            Button1.BackColor = Color.Green
            Button5.BackColor = Color.Green
            Button9.BackColor = Color.Green
            MessageBox.Show("Winner is " + player2, "Tic-Toc-Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(PlayerB.Text)
            PlayerB.Text = Convert.ToString(addOneToScore + 1)
            ButtonsEnabledFalse()
        End If
        'check win for player B is complete

        'score green white condition
        If PlayerA.Text > PlayerB.Text Then
            PlayerA.ForeColor = Color.Green
            PlayerB.ForeColor = Color.Gray

        ElseIf PlayerB.Text > PlayerA.Text Then
            PlayerB.ForeColor = Color.Green
            PlayerA.ForeColor = Color.Gray
        Else
            PlayerA.ForeColor = Color.Gray
            PlayerB.ForeColor = Color.Gray
        End If

    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click
        Dim b As Button = sender
        If checkForXorO = False Then
            b.Text = "X"
            checkForXorO = True
        Else
            b.Text = "O"
            checkForXorO = False
        End If
        CheckForWin()
        b.Enabled = False
    End Sub

    Private Sub Reset_Btn_Click(sender As Object, e As EventArgs) Handles Reset_Btn.Click
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True

        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""

        Button1.BackColor = Color.White
        Button2.BackColor = Color.White
        Button3.BackColor = Color.White
        Button4.BackColor = Color.White
        Button5.BackColor = Color.White
        Button6.BackColor = Color.White
        Button7.BackColor = Color.White
        Button8.BackColor = Color.White
        Button9.BackColor = Color.White
    End Sub

    Private Sub NewGame_btn_Click(sender As Object, e As EventArgs) Handles NewGame_btn.Click
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True

        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""

        Button1.BackColor = Color.White
        Button2.BackColor = Color.White
        Button3.BackColor = Color.White
        Button4.BackColor = Color.White
        Button5.BackColor = Color.White
        Button6.BackColor = Color.White
        Button7.BackColor = Color.White
        Button8.BackColor = Color.White
        Button9.BackColor = Color.White

        PlayerA.Text = "0"
        PlayerB.Text = "0"
        player1 = ""
        player2 = ""
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        Dim checkForExit As DialogResult = MessageBox.Show("Confirm, if you want to exit", "Tic-Toc-Toe Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If checkForExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub PlayerA_Click(sender As Object, e As EventArgs) Handles PlayerA.Click

    End Sub
End Class
