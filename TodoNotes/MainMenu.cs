using Microsoft.VisualBasic;
using model;
using model.exceptions;

namespace TodoNotes
{
    public partial class MainMenu : Form
    {
        DeckManager DeckManager = new();
        public MainMenu()
        {
            InitializeComponent();
            InitalizeDeckList();
        }
        private void InitalizeDeckList()
        {
            deckList.DataSource = DeckManager.Decks;
        }

        private void NewDeckButton_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Please name the deck", "Enter Text");
            if (!DeckManager.AddNewDeckWithName(name))
            {
                MessageBox.Show("A deck with this name already exists!");
            }
        }

        private void DeleteDeckButton_Click(object sender, EventArgs e)
        {
            Deck? deck = SelectDeckHelper();
            if (deck != null)
            {
                DeckManager.RemoveDeckWithName(deck.Name);
            }
        }

        private void ViewDeckButton_Click(object sender, EventArgs e)
        {
            Deck? deck = SelectDeckHelper();
            if (deck != null)
            {
                _ = new DeckMenu(deck).ShowDialog();
                deckList.Refresh();
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeckManager.SaveFile();
            MessageBox.Show("File Saved");
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DeckManager = DeckManager.LoadFile();
                deckList.DataSource = DeckManager.Decks;
                MessageBox.Show("File Loaded");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No save file found.");
            }
        }

        private void DrawHandButton_Click(object sender, EventArgs e)
        {
            Deck? deck = SelectDeckHelper();
            if (deck == null) { return; }
            int i = NumPicker();
            try
            {
                DisplayHand(deck.DrawCards(i));
            }
            catch (CardOverflowException)
            {
                MessageBox.Show("There are not enough cards in the deck to draw this hand.");
            }
        }

        private void DisplayHand(List<Card> cards)
        {
            string display = "";
            foreach (Card c in cards)
            {
                display += $"{c.Todo} => {c.Score}\n";
            }
            MessageBox.Show(display, "Hand");
        }

        private Deck? SelectDeckHelper()
        {
            if (deckList.SelectedRows.Count > 0)
            {
                Deck deck = (Deck) deckList.SelectedRows[0].DataBoundItem;
                return deck;
            }
            else
            {
                MessageBox.Show("No deck is selected.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        private static int NumPicker()
        {
            while (true)
            {
                string m = "How many cards to draw?";
                string s = Interaction.InputBox(m, "Enter Number");
                try
                {
                    int count = Int32.Parse(s);
                    if (count > 0)
                    {
                        return count;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a positive number");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a number");
                }
            }
        }
    }
}
