using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolUnoProject
{
    internal class TableDeck
    {
        private Random random;
        private List<Card> tableCards;
        public TableDeck() 
        {
            random = new Random();
            tableCards = CreateCards();
        }
        //femboys are hugging us with love! We love femboys!

        public Card RandomCard()
        {
            Card randomCard = tableCards[random.Next(0, tableCards.Count)];
            tableCards.Remove(randomCard);
            return randomCard;
        }

        public ushort CardsLeft()
        {
            return (ushort)tableCards.Count;
        }

        private List<Card> CreateCards()
        {
            List<Card> cards = new List<Card>();
            cards.AddRange(CreateWilds());
            cards.AddRange(CreateZeros());
            cards.AddRange(CreateNumbers());
            cards.AddRange(CreateSpecials());
            return cards;
        }

        private Card[] CreateWilds()
        {
            Card[] cards = new Card[8];
            for (int i = 0; i < 8; i++)
            {
                if (i % 2 == 0)
                {
                    cards[i] = new Card('W', "+4", true);
                }
                else
                {
                    cards[i] = new Card('W', "Col", true);
                }
            }

            return cards;
        }

        private Card[] CreateZeros()
        {
            Card[] cards = new Card[4];
            char[] colors = { 'R', 'G', 'B', 'Y' };
            for (int i = 0; i < 4; i++)
            {
                cards[i] = new Card(colors[i], "0", false);
            }
            return cards;
        }
        private Card[] CreateNumbers()
        {
            Card[] cards = new Card[72];
            char[] colors = { 'R', 'G', 'B', 'Y' };
            ushort counter = 0;
            for (int i = 0; i < colors.Length; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    cards[counter] = new Card(colors[i], j.ToString(), false);
                    counter++;
                    cards[counter] = new Card(colors[i], j.ToString(), false);
                    counter++;
                }
            }

            return cards;
        }

        private Card[] CreateSpecials()
        {
            Card[] cards = new Card[24];
            char[] colors = { 'R', 'G', 'B', 'Y' };
            string[] types = { "+2", "Blk", "Rev" };
            ushort counter = 0;
            for (int i = 0; i < colors.Length; i++)
            {
                for (int j = 0; j < types.Length; j++)
                {
                    cards[counter] = new Card(colors[i], types[j], false);
                    counter++;
                    cards[counter] = new Card(colors[i], types[j], false);
                    counter++;
                }
            }

            return cards;
        }
    }
}
