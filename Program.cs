namespace SchoolUnoProject
{
    class Card
    {

    }
    class Deck
    {

    }

    class Game
    {

    }

    class Player
    {
        private Deck deck;

        public Player(Deck deck)
        {
            this.deck = deck;
        }

        public void ListCards()
        {
            //deck.ListCards();
        }

        public Card SelectCard(string cardname)
        {
            if(string.IsNullOrEmpty(cardname))
            {
                return null;
            }


            Card selectedCard = new Card(); //deck.GetCard(cardname);

            if(true) //if (selectedCard != null)
            {
                return new Card(); //selectedCard;

                // the card goes back to Game and is played, aka put on the pile!
            } else
            {
                return null;
            }

            //if(deck.ListCards().Cont;

        }
    }

    class Program
    {
        public static void Main()
        {

        }

    }

}
