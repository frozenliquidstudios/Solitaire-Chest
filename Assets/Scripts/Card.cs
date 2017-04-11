using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card {
    private Suit cardSuit { get; set; }
    private Value cardValue { get; set; }

    public Card(Suit suit, Value value) {
        cardSuit = suit;
        cardValue = value;
    }

    public int getIntValue() { // Get card value as an integer
        return (int)cardValue;
    }
    public string getSuitName() { // Get card suit as a string
        return cardSuit.ToString();
    }

    public string getFullCardString() {
        return cardValue + " of " + cardSuit;
    }
}
