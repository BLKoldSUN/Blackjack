Imports System.Collections

Public Class Deck
    Private deck(51) As Card
    Private shuffledDeckOfCards As New Stack()

    ' Creates 52 unique cards (Card.vb). Shuffels them, and then converts them to a stack for dealing.
    Public Sub New()
        ' Makes a fresh deck of cards
        For number As Integer = 0 To 51
            deck(number) = New Card(number)
        Next
        DeckShuffle()
        ConvertToSTack()
    End Sub

    ' Returns the top card without discarding it.
    Public Function lookTopCard() As Card
        Return shuffledDeckOfCards.Peek()
    End Function

    ' Deals the top card from the deck to a hand.
    Public Function getTopCard() As Image
        Return shuffledDeckOfCards.Pop().GetImage()
    End Function

    ' The algorithm for shuffling the deck. Makes each card swap with a random card 4 times.
    Private Sub DeckShuffle()
        ' shuffles the deck 4 times.
        For shufflingCards As Integer = 0 To 3
            ' goes through each card and changes position once each time it goes through shufflingCards
            For shuffleEachCard As Integer = 0 To 51
                ' gets a random number 0 - 51
                Dim placeHolder As Integer = GetRandom(0, 51)
                ' creates a temporary card for swapping cards
                Dim tempCard As Card = deck(placeHolder)
                ' makes the random number card now the card we were shuffling
                deck(placeHolder) = deck(shuffleEachCard)
                ' replaces the card we were shuffling with the one we were saving as a temporary
                deck(shuffleEachCard) = tempCard
            Next
        Next
    End Sub

    ' Converts the deck() array into a stack for easy dealing.
    Private Sub ConvertToSTack()
        For index As Integer = 0 To 51
            shuffledDeckOfCards.Push(deck(index))
        Next
    End Sub

    ' Gets a random number for shuffling.
    Private Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

End Class