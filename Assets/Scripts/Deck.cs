using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Deck
{
    private List<Card> deck { get; set; }
    private int cardCount;

    public Deck() {
        deck = new List<Card>();
        cardCount = 0;
    }

    public void addCard(Card card) {
        deck.Add(card);
    }

    public Card dealCard() {
        if (cardCount >= deck.Count) return null;
        else return (Card)deck[cardCount++];
    }

    public int getDeckSize() {
        return deck.Count;
    }

    public int cardsRemaining() {
        return getDeckSize() - cardCount;
    }

    public bool hasCards() {
        if (cardCount > getDeckSize()) return true;
        else return false;
    }

    public void fillDeck()
    {
        for (var i = 1; i < 5; i++) // Iterate through all Suits
        {
            for (var x = 1; x < 14; x++) // Iterate through all values
            {                                           
                addCard(new Card((Suit)i, (Value)x)); // Add card with Suit [i] and Value [x]
            }
        }
    }
    public void Shuffle()
    {
        System.Random rnd = new System.Random();
        for (int i = deck.Count - 1; i >= 0; i--)
        {
            int r = rnd.Next(0, i + 1);

            Card tmp = deck[i];
            deck[i] = deck[r];
            deck[r] = tmp;
        }
    }
}

/* FISHER–YATES ALGORITHM FOR SHUFFLING
To shuffle an array a of n elements (indices 0..n-1):
    for i from n−1 downto 1 do
        j ← random integer such that 0 ≤ j ≤ i
        exchange a[j] and a[i]
*/