namespace SchoolUnoProject
{
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

        public Card[] ListCards()
        {
            Card[] cards = new Card[2];
            cards[0] = new Card();
            cards[1] = new Card();
            return new Card[1];
            //return deck.ListCards();
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
            Deck deck = new Deck();
            Player player = new Player(deck);
            Console.WriteLine("Player's cards:");
            Console.WriteLine("Type the name of the card you want to play:");
            string playerinput = Console.ReadLine();
            while (player.SelectCard(playerinput) == null)
            {
                Console.WriteLine("Invalid card name, please try again:");
                playerinput = Console.ReadLine();
            }
            Console.WriteLine("Card played!");



        }

    }

}
