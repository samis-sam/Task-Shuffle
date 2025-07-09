using System.Collections;
using System.ComponentModel;
using model.exceptions;

namespace model;

public class Deck(string name, BindingList<Card> cards)
{
    public string Name { get; set; } = name;
    public BindingList<Card> Cards { get; set; } = cards;
    public int Count { get; set; } = 0;
    readonly Random rng = new();

    // EFFECTS: Draws given amount of cards from the deck, no replacement
    public List<Card> DrawCards(int count)
    {
        if (count > Cards.Count) {throw new CardOverflowException();}
        List<Card> subDeck = new(Cards);
        List<Card> hand = [];
        for (int i = 0; i < count; i++)
        {
            int pos = rng.Next(subDeck.Count - 1);
            hand.Add(subDeck[pos]);
            subDeck.RemoveAt(pos);
        }
        return hand;
    }

    // Returns first instance, null if none found
    public Card? GetCardWithName(string name)
    {
        Card? card = null;
        foreach (Card c in Cards)
        {
            if (c.Todo.Equals(name))
            {
                card = c;
                break;
            }
        }
        return card;
    }

    // MODIFIES: this
    // EFFECTS: Adds given Card c to the deck if not already in it and gives true, otherwise false
    public bool AddCard(Card c)
    {
        if (!Cards.Where(s => s.Todo == c.Todo).Any())
        {
            Cards.Add(c);
            UpdateCount();
            return true;
        }
        else
        {
            return false;
        }
    }

    // MODIFIES: this
    // EFFECTS: Remove card by name, return true if sucess
    public bool RemoveCard(string name)
    {
        Card? card = GetCardWithName(name);
        if (card != null)
        {
            Cards.Remove(card);
            UpdateCount();
            return true;
        }
        else
        {
            return false;
        }
    }

    private void UpdateCount()
    {
        Count = Cards.Count;
    }
}