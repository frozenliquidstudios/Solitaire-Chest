using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TEST_deck : MonoBehaviour{

    Deck deck = new Deck();
    SpriteRenderer spriteRenderer;
    public Sprite[] faces;
    public Sprite cardBack;
    public int cardIndex; // e.g. faces[cardIndex];

    // Use this for initialization
    void Start () {
        deck.fillDeck();
        deck.Shuffle();
        cardBack = Resources.Load<Sprite>("cardBack");
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = cardBack;
        //card2.text = deck.dealCard().getFullCardString();
        //card3.text = deck.dealCard().getFullCardString();
}
	
	// Update is called once per frame
	void Update () {
        
    }
}
