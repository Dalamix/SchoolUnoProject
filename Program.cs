using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace SchoolUnoProject
{
    class Deck
    {
        public Deck(Deck deck)
        {
            
        }

        public Card[] ListCards()
        {
            Card[] cards = new Card[2];
            cards[0] = new Card();
            cards[1] = new Card();
            return new Card[1];
            //return deck.ListCards();
        }
        public void PickUpCard(Player player)
        {
            Card newCard = new Card();
            Console.WriteLine($"{player} picked up a card: {newCard.Name}");
            Console.WriteLine(); // empty line for readability
        }
    }
    public class Card
    {
        private Random random = new Random();

        private char[] Colors =
        {
            'R', 'G', 'B', 'Y', 'W'
        };
        private string[] Types =
        {
            "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "+2", "Blk", "Rev", "+4", "Col"
        };


        public char Color;
        public string Type;
        public string Name;
        public bool? Special;

        // Creating a card object will randomly select color and type
        public Card()
        {
            Type = Types[random.Next(Types.Length)];
            Special = (!Char.IsNumber(Type[0])) ? true : false;
            // We cant have a wildcard 6, it needs to be a special (+4 or color switch)
            if (Special == true && (Type == "+4" || Type == "Col"))
            {
                Color = 'W';
            }
            else
            {
                Color = Colors[random.Next(Colors.Length - 4)];
            }
            Name = Color.ToString() + " " + Type;
        }
    }

    class Player
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        public static List<Player> CreatePlayers(int count)
        {
            List<Player> players = new List<Player>();
            for (int i = 1; i <= count; i++)
            {
                players.Add(new Player($"Player{i}"));
            }
            return players;
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
    }

    interface UI
    {
        //void ShowHand(List<string> hand);
        //string PickUpCard(List<string> hand);
        //void ShowAction(string message);
        int Start();
        void Cardusage();
    }

    class UserInterface : UI
    {
        //public void ShowHand(List<string> hand)
        //{
        //    Console.WriteLine("These are your cards: ");
        //}

        //public string PickUpCard(List<string> hand)
        //{

        //}

        //public void ShowAction(string message)
        //{

        //}
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
        public void Cardusage()
        {
            Console.WriteLine("Player's cards:");
            //for(int i = 0; i < player.ListCards().Length; i++)
            //{
            //    Console.WriteLine($"Card {i+1}");
            //}
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
            List<Player> players = Player.CreatePlayers(playercount);

            for(int i = 0; i <= playercount; i++)
            {
                Deck deck = new Deck();
                players[i].Deck = deck;
            }
        }
    }
}
//bool playernumber = false;
//bool start = false;
//if (Console.ReadLine() == "start".ToLower())
//{
//    start = true;
//}     
//else
//{
//    Console.WriteLine("go fuck yourself");
//}
//Console.WriteLine("How many players do you want");
//playernumber = int.TryParse(Console.ReadLine(), out int playercount);