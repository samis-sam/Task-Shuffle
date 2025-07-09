using Microsoft.VisualBasic;
using model;
using model.exceptions;

namespace TodoNotes
{
    public partial class DeckMenu : Form
    {
        readonly Deck deck;
        public DeckMenu(Deck deck)
        {
            InitializeComponent();
            this.deck = deck;
            InitalizeCardList();
        }
        private void InitalizeCardList()
        {
            cardList.DataSource = deck.Cards;
        }

        private void NewCardButton_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Please write the task of the card", "Enter Text");
            int score = GetScoreFromUser();
            if (!deck.AddCard(new(name, score)))
            {
                MessageBox.Show("A card with this name already exists!");
            }
        }

        private void DeleteCardButton_Click(object sender, EventArgs e)
        {
            if (cardList.SelectedRows.Count > 0)
            {
                Card card = (Card) cardList.SelectedRows[0].DataBoundItem;
                deck.RemoveCard(card.Todo);
            }
            else
            {
                MessageBox.Show("No card is selected.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private static int GetScoreFromUser()
        {
            while (true)
            {
                string m = "Please enter the prioirty level of the card from 1 - 5";
                string s = Interaction.InputBox(m, "Enter Number");
                try
                {
                    int score = Int32.Parse(s);
                    if (score >= 1 && score <= 5)
                    {
                        return score;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a number within 1 and 5");
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
