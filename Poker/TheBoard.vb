' Author: Brandon Finley
' Date: 10/21/2017
' TODO: Add music. Add time so the cards get placed 1 at a time.
' Stats: BUGGED~Reset button needs to be creating a new deck, but it's currently using the same one and eventually win run out of cards and crash the program.
' The best score I've got is $11,270 :) Good luck trying to beat it.

Public Class TheBoard
    Private deck As New Deck
    Private Player As New Hand(270, 340, "Player", deck)
    Private Dealer As New Hand(270, 150, "Dealer", deck)
    Private playersCash As Double = 500
    Private pb As New PictureBox

    ' A little backwards, but basically just makes user press reset button if they False is passed. Turn on buttons if True.
    Private Sub ForceReset(Enabled As Boolean)
        hitButton.Enabled = Enabled
        StandButton.Enabled = Enabled
    End Sub

    ' Initializes 2 cards for gambler and 2 cards for dealer.
    Private Sub TheBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' give the player 2 cards and 2 dealer cards
        Player.AddCards(True)
        Player.AddCards(True)
        Dealer.AddCards(False)

        yourCashTextBox.Text = Format(playersCash, "currency")
    End Sub

    ' Adds cards to players hand.
    Private Sub hitButton_Click(sender As Object, e As EventArgs) Handles hitButton.Click
        If validateData(betAmountTextBox.Text) = True Then
            Player.AddCards(True)
            If Player.AceSwitch > 21 Then
                ' lose cash
                MessageBox.Show("You've busted. Better luck next time!")
                playersCash = playersCash - betAmountTextBox.Text
                yourCashTextBox.Text = Format(playersCash, "currency")
                ForceReset(False)
                Me.AcceptButton = ResetButton
            End If
        End If
    End Sub

    ' Allows dealer to try and beat your current hand.
    Private Sub StandButton_Click(sender As Object, e As EventArgs) Handles StandButton.Click
        If validateData(betAmountTextBox.Text) = True Then
            Me.Controls.Remove(pb)
            Select Case CheckWinLoss()
                Case 1
                    ' Normal win
                    playersCash = playersCash + betAmountTextBox.Text
                    yourCashTextBox.Text = Format(playersCash, "currency")
                Case 2
                    ' Tie game
                    playersCash = playersCash
                    yourCashTextBox.Text = Format(playersCash, "currency")
                Case 3
                    ' Loss
                    playersCash = playersCash - betAmountTextBox.Text
                    yourCashTextBox.Text = Format(playersCash, "currency")
                Case 4
                    ' Blackjack!
                    playersCash = playersCash + (betAmountTextBox.Text * 1.5)
                    yourCashTextBox.Text = Format(playersCash, "currency")
            End Select
            ForceReset(False)
            Me.AcceptButton = hitButton
        End If
    End Sub

    ' Resets the game (currently bugged not creating a new deck).
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Clear_Form(Me)
        ForceReset(True)
        hitButton.Select()

        ' place 2 cards on table for player and 1 for dealer
        Player.AddCards(True)
        Player.AddCards(True)
        Dealer.AddCards(False)
        Dealer.AddCards(True)

        ' Mystery card for dealer
        pb.SizeMode = PictureBoxSizeMode.AutoSize
        pb.Location = New Point(360, 150)
        Me.Controls.Add(pb)
        pb.Image = My.Resources.back2
        pb.BringToFront()
        Me.AcceptButton = hitButton
    End Sub

    ' Clears all cards off table and sets up new table.
    Private Sub Clear_Form(ByRef container As Control)
        ' for some reason not all picture boxes are being removed with just one click, so to be safe i made it remove picture boxes 4 times
        Dim rmvCount As Integer = 0
        While rmvCount < 5
            For Each tempControl In container.Controls
                If TypeOf tempControl Is PictureBox Then
                    Me.Controls.Remove(tempControl)
                End If
            Next
            rmvCount = rmvCount + 1
        End While

        Player.Reset()
        Dealer.Reset()
    End Sub

    ' Makes sure the bet amount is a number.
    Private Function validateData(ThingToTest As String) As Boolean
        If ThingToTest.Trim = String.Empty Then
            ' The number in PriceBox must be a positive number or else an error to the user gets thrown.
            MsgBox("Must enter a number in the bet amount. Setting amount to table minimum.",
            MsgBoxStyle.Information, "Verify")
            betAmountTextBox.Text = 10
            Return False
        ElseIf IsNumeric(ThingToTest) = False Then
            MsgBox("Must enter a number in the bet amount.",
            MsgBoxStyle.Information, "Verify")
            betAmountTextBox.Focus()
            betAmountTextBox.SelectAll()
            Return False
        ElseIf ThingToTest < 10 Then
            MsgBox("Table minimum $10.",
            MsgBoxStyle.Information, "Verify")
            betAmountTextBox.Focus()
            betAmountTextBox.SelectAll()
            Return False
        ElseIf ThingToTest > playersCash Then
            MsgBox("You don't have that much money!",
            MsgBoxStyle.Information, "Verify")
            betAmountTextBox.Focus()
            betAmountTextBox.SelectAll()
        Else
            Return True
        End If
    End Function

    ' Decides winner between the gambler and dealer.
    Private Function CheckWinLoss() As Integer
        ' 1 = Win, 2 = Tie, 3 = Loss, 4 = Blackjack
        If (Player.GetPoints = 21 And Player.PlayerTurns = 3) Then
            If (Dealer.AceSwitch() < 21) Then
                MessageBox.Show("Black Jack! You've won " + Format(betAmountTextBox.Text * 1.5, "currency"))
                Return 4
            Else
                ' if the dealer does have an ace and a card worth 10, it's a tie
                MessageBox.Show("Tie!")
                Return 2
            End If
        Else
            ' if the player has hit at least once the dealer must draw until 17 and stay
            While Dealer.AceSwitch() < 17
                Dealer.AddCards(True)
            End While

            ' conditions for player to win/tie/lose if not initial Blackjack
            If (Player.GetPoints > Dealer.AceSwitch() And Player.GetPoints < 22) Then
                MessageBox.Show("You win! You've won " + Format(betAmountTextBox.Text, "currency"))
                Return 1
            ElseIf (Dealer.GetPoints > 21 And Player.GetPoints < 22) Then
                MessageBox.Show("Dealer bust. You win! You've won " + Format(betAmountTextBox.Text, "currency"))
                Return 1
            ElseIf (Player.GetPoints = Dealer.AceSwitch()) Then
                MessageBox.Show("Tie!")
                Return 2
            Else
                MessageBox.Show("Dealer wins. Better luck next time!")
                Return 3
            End If
        End If
    End Function

    ' Exits application.
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class