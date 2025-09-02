using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace SchoolUnoProject
{
    class Player
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }

        public Player(string name)
        {
            Name = name;
        }
    }
    class Game
    {
        public Card SelectCard(string cardname)
        {
            if (string.IsNullOrEmpty(cardname))
            {
                return null;
            }


            Card selectedCard = new Card(); //deck.GetCard(cardname);

            if (true) //if (selectedCard != null)
            {
                return new Card(); //selectedCard;

                // the card goes back to Game and is played, aka put on the pile!
            }
            else
            {
                return null;
            }
            //if(deck.ListCards().Cont;
        }
        
    }

    class UserInterface
    {
        public int Start()
        {
            string input = "";
            while (input.ToLower() != "start")
            {
                Console.Write("Type 'start' to begin the game: ");
                input = Console.ReadLine();
                Console.WriteLine();
            }

            int playerCount = 0;
            while (true)
            {
                Console.Write("Enter number of players (2-4): ");
                string countInput = Console.ReadLine();

                if (int.TryParse(countInput, out playerCount) && playerCount >= 2 && playerCount <= 4)
                {
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("Invalid number. Please enter a number between 2 and 4.");
            }
            Console.WriteLine($"Game started with {playerCount} players");
            return playerCount;
        }
        public void pickup(Player player)
        {
            string input = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (input == "pickup")
            {
                Deck.PickUpCard(player);
            }
            else
            {
                Console.WriteLine("Unknown Command");
                Console.WriteLine();
            }
        }

        public void Cardusage()
        {
            Console.WriteLine("Player's cards:");
            //for(int i = 0; i < player.ListCards().Length; i++)
            //{
            //    Console.WriteLine($"Card {i+1}");
            //}
            Console.WriteLine("Type the name of the card you want to play:");
            string playerinput = Console.ReadLine();
            while (Player.SelectCard(playerinput) == null)
            {
                Console.WriteLine("Invalid card name, please try again:");
                playerinput = Console.ReadLine();
            }
            Console.WriteLine("Card played!");
        }
    }

    class Program
    {
        public static void Main()
        {
            UserInterface userinterface = new UserInterface();
            int playercount = userinterface.Start();
            if (playercount != 2 || playercount != 3 || playercount != 4)
            {
                return;
            }

            for(int i = 0; i <= playercount; i++)
            {
                Deck deck = new Deck();
                players[i].Deck = deck;
            }
        }
    }
}