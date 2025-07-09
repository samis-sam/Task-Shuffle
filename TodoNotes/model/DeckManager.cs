using System.Text.Json;
using model.exceptions;
using System.ComponentModel;

namespace model;

// For housing deck management methods
public class DeckManager()
{
    public BindingList<Deck> Decks { get; set; } = [];
    private JsonSerializerOptions Options = new() { WriteIndented = true };

    // Returns first instance, null if none found
    public Deck? GetDeckWithName(string name)
    {
        Deck? deck = null;
        foreach (Deck d in Decks)
        {
            if (d.Name.Equals(name))
            {
                deck = d;
                break;
            }
        }
        return deck;
    }

    // Returns false if deck already exists with this name
    public bool AddNewDeckWithName(String name)
    {
        if (!HasDeckWithName(name))
        {
            Decks.Add(new(name, []));
            return true;
        }
        else
        {
            return false;
        }
    }

    // Removes first deck in decks with given name, there should only be one anyways
    public bool RemoveDeckWithName(String name)
    {
        Deck? deck = GetDeckWithName(name);
        if (deck != null)
        {
            return Decks.Remove(deck);
        }
        else
        {
            return false;
        }
    }

    private bool HasDeckWithName(String name)
    {
        return Decks.Where(n => n.Name == name).Any();
    }

    public void SaveFile()
    {
        File.WriteAllText("savefile.json", JsonSerializer.Serialize<DeckManager>(this, Options));
    }

    public static DeckManager LoadFile()
    {
        string jsonSave = File.ReadAllText("savefile.json");
        var newDeckMan = JsonSerializer.Deserialize<DeckManager>(jsonSave) ?? new();
        return newDeckMan;
    }
}
