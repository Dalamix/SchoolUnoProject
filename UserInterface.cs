using System.Numerics;

namespace SchoolUnoProject
{
    public class UserInterface
    {
        public Player[] Start()
        {
            string? input = "";
            Console.WriteLine("Welcome to UNO!\n==========");

            int playerCount;
            while (true)
            {
                Console.Write("Enter number of players (2-4): ");
                string? countInput = Console.ReadLine();

                if (int.TryParse(countInput, out playerCount) && playerCount >= 2 && playerCount <= 4)
                {
                    break;
                }
                Console.WriteLine("\nInvalid number. Please enter a number between 2 and 4.");
            }
            Player[] playersToReturn = new Player[playerCount];
            for (int i = 0; i < playerCount; i++)
            {
                Console.Write($"Enter name for Player {i}: ");
                string playerName = Console.ReadLine(); 
                while(string.IsNullOrEmpty(playerName))
                {
                    Console.WriteLine("You fucker. Write a name.");
                    playerName = Console.ReadLine();
                }
                Player player = new Player(playerName);
                playersToReturn[i] = player;
                Console.WriteLine($"Player {i} is named {playerName}");
            }
            Console.WriteLine($"Game started with {playerCount} players.");
            return playersToReturn;
        }
        public void PickUp(Player player)
        {
            string input = Console.ReadLine().ToLower();
            Console.WriteLine();
        }

        public void CardUsage(Player plr)
        {
            Console.WriteLine("Player's cards:");
            string[] cardNames = plr.ListCards();
            for (int i = 0; i < plr.CardsLeft(); i++)
            {
                Console.WriteLine($"Card {i + 1}: {cardNames[i]}");
            }
            Console.WriteLine("Type the name of the card you want to play:");
            string playerinput = Console.ReadLine();
            while (plr.SelectCard(playerinput) == null)
            {
                Console.WriteLine("Invalid card name, please try again:");
                playerinput = Console.ReadLine();
            }
            Console.WriteLine("Card played!");
        }

        public string Interpreter(Player plr)
        {
            Console.WriteLine("Player's cards:");
            for (int i = 0; i < player.ListCards().Length; i++)
            {
                Console.WriteLine($"Card {i + 1}");
            }
            string input = Console.ReadLine().ToLower();
            if (input == "pickup")
            {
                return input;
            }
            else if (plr.SelectCard(input) != null)
            {
                return input;
            }
            else
            {
                return "";
            }

        }
    }
}
