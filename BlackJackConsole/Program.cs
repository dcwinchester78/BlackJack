using BlackJackEngine;
using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Welcome to BlackJack!");

// Create a deck of 52 cards
var deck = new List<Card>();
foreach (Suit suit in Enum.GetValues(typeof(Suit)))
{
    foreach (Rank rank in Enum.GetValues(typeof(Rank)))
    {
        deck.Add(new Card(suit, rank));
    }
}

// Shuffle the deck
var random = new Random();
var shuffledDeck = deck.OrderBy(c => random.Next()).ToList();

// Create and print 10 hands of 2 cards
for (int i = 0; i < 10; i++)
{
    var handCards = new List<Card>
    {
        shuffledDeck[i * 2],
        shuffledDeck[i * 2 + 1]
    };
    var hand = new Hand(handCards);

    Console.WriteLine($"Hand {i + 1}:");
    foreach (var card in hand.Cards)
    {
        Console.WriteLine($"  {card.Rank} of {card.Suit}");
    }
    Console.WriteLine();
}