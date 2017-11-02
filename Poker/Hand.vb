Public Class Hand
    Private handCounter As Integer = 0
    Private counter As Integer = 1
    Private nextRow As Integer = 0
    Private xPos As Integer
    Private yPos As Integer
    Private halfOfCard As Integer = 45
    Private who As String
    Private deck As Deck
    Private aceCounter As Integer = 0

    ' Creates a new card and gets a point to start placing cards on the table.
    Public Sub New(xPosOfCard As Integer, yPosOfCard As Integer, name As String, TheDeck As Deck)
        xPos = xPosOfCard
        yPos = yPosOfCard
        who = name
        deck = TheDeck
    End Sub

    ' Used to check if a player is dealt a blackjack.
    Public Function PlayerTurns() As Integer
        Return counter
    End Function

    ' Used for checking who wins (dealer vs player).
    Public Function GetPoints() As Integer
        Return handCounter
    End Function

    ' Keeps track of how much hand is worth. 
    Public Sub AddCards(drawInFront As Boolean)
        ' used to count for flexible Aces
        If (deck.lookTopCard.GetPointValueOfCard = 11) Then
            handCounter = handCounter + deck.lookTopCard.GetPointValueOfCard()
            aceCounter = aceCounter + 1
        Else
            ' anything else get's the value of card
            handCounter = handCounter + deck.lookTopCard.GetPointValueOfCard()
        End If
        MakeCardImage(drawInFront)
    End Sub

    ' Code to allow Aces to be either 1 or 11.
    Public Function AceSwitch() As Integer
        ' if your hand exceeds 21 you bust. If you have an ace in your hand and exceed 21 make the ace a 1 and don't bust.
        If (handCounter > 21 And aceCounter > 0) Then
            handCounter = handCounter - 10
            aceCounter = aceCounter - 1
        End If
        Return handCounter
    End Function

    ' When pressing reset button.
    Public Sub Reset()
        handCounter = 0
        counter = 1
        nextRow = 0
        aceCounter = 0
    End Sub

    ' Draws the cards on the screen.
    Private Sub MakeCardImage(drawInFront As Boolean)
        ' gives the dimensions of the card and where to position it.
        Dim pb As New PictureBox
        pb.SizeMode = PictureBoxSizeMode.AutoSize
        pb.Location = New Point((counter * halfOfCard + xPos), (nextRow + yPos))
        TheBoard.Controls.Add(pb)
        pb.Image = deck.getTopCard()
        If (drawInFront = True) Then
            pb.BringToFront()
        End If
        ' starts a new row of cards
        If (counter > 4) Then
            counter = 0
            nextRow = 40
        End If
        counter = counter + 1
    End Sub
End Class
