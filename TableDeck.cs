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
            for (int i = 0; i < 108; i++)
            {
                tableCards = CreateCards();
            }

        }

        private List<Card> CreateCards()
        {
            List<Card> cards = new List<Card>();
            cards.AddRange(CreateWilds());

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
            Card[] cards = new Card[5];
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
            for (int i = 0; i < 4; i++)
            {
                cards[counter] = new Card(colors[i], "0", false);
            }

            return cards;
        }

        public Card RandomCard()
        {
            Card randomCard = tableCards[random.Next(0, tableCards.Count)];
            tableCards.Remove(randomCard);
            return randomCard;
        }
    }
}
