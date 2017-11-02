' Questions: What about deconstructors, and how can i not use global variables, but rather use variables inside of a constructor in functions?

Public Class Card
    ' A card should have: a value (ace, two, three, ...), a suit (Spade, Heart, Club, Diamond), and a raw value 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
    '                     an image of what it looks like.
    Private CardPoint As Integer
    Private CardVal As String
    Private CardSuit As String
    Private CardFace As Image

    ' Constucting a card sets the image and the point value of card.
    Public Sub New(ByVal cNum As Integer)
        ' Assigns 10 to jack queen and king
        If (cNum Mod 13 = 0) Then
            CardPoint = 11
        ElseIf (cNum Mod 13 > 0 And cNum Mod 13 < 10) Then
            CardPoint = (cNum Mod 13) + 1
        Else
            CardPoint = 10
        End If
        CardFace = StartDeckCounter(cNum)
    End Sub

    ' Returns pount value of a card.
    Public Function GetPointValueOfCard() As Integer
        Return CardPoint
    End Function

    ' Returns the image of the card.
    Public Function GetImage()
        Return CardFace
    End Function

    ' Creates a card given a number 0-51.
    Private Function StartDeckCounter(CurrentCard As Integer) As Image
        Dim TheVal As Integer = CurrentCard Mod 13
        ' Math.Floor makes sure the number is not rounded up.
        Dim TheSuit As Integer = Math.Floor(CurrentCard / 13)
        FromNumsToCards(TheVal, TheSuit)
        ' ResourceManage.GetObject allows a string to pass as a reference to a resource image.
        Return My.Resources.ResourceManager.GetObject(CardVal + "Of" + CardSuit)
    End Function

    ' Gives values of Ace through king and which suit for cards.
    Private Sub FromNumsToCards(FaceVal As Integer, Suit As Integer)
        Select Case FaceVal
            Case 0
                CardVal = "Ace"
            Case 1
                CardVal = "Two"
            Case 2
                CardVal = "Three"
            Case 3
                CardVal = "Four"
            Case 4
                CardVal = "Five"
            Case 5
                CardVal = "Six"
            Case 6
                CardVal = "Seven"
            Case 7
                CardVal = "Eight"
            Case 8
                CardVal = "Nine"
            Case 9
                CardVal = "Ten"
            Case 10
                CardVal = "Jack"
            Case 11
                CardVal = "Queen"
            Case 12
                CardVal = "King"
        End Select

        Select Case Suit
            Case 0
                CardSuit = "Spades"
            Case 1
                CardSuit = "Hearts"
            Case 2
                CardSuit = "Clubs"
            Case 3
                CardSuit = "Diamonds"
        End Select
    End Sub
End Class
