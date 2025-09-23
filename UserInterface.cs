using System.Numerics;

namespace SchoolUnoProject
{
    public class UserInterface
    {
        public Rules rules;
        public Player[] Start()
        {

            string? input = "";
            while (input.ToLower() != "start")
            {
                Console.Write("Type 'start' to begin the game: ");
                input = Console.ReadLine();
                Console.WriteLine();
            }

            while (true)
            {
                Console.WriteLine("Which ruleset do you want to play with?");
                Console.WriteLine("Classic (1.), stacking (2.), force play (3.), or 7s and 0s (4.)");
                string countInput = Console.ReadLine();
                int choice;
                if(int.TryParse(countInput, out choice))
                {
                    if (choice == 1)
                    {
                        rules = new Rules("Classic");
                        Console.WriteLine("You chose classic rules!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("These rules are yet not available!");
                    }
                }
                
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
            Player[] playersToReturn = new Player[playerCount];
            for (int i = 0; i < playerCount; i++)
            {
                Console.Write($"Enter name for Player {i+1}: ");
                string playerName = Console.ReadLine(); 
                while(string.IsNullOrEmpty(playerName))
                {
                    Console.WriteLine("You fucker. Write a name.");
                    playerName = Console.ReadLine();
        }
                Player player = new Player(playerName);
                playersToReturn[i] = player;
                Console.WriteLine($"Player {i+1} is named {playerName}");
            }
            Console.WriteLine($"Game started with {playerCount} players.");
            return playersToReturn;
        }
        private void Line()
        {
            Console.WriteLine("--------------");
        }

        // I've decided to split this into it's own function because of the way
        // we handle incorrect cards being selected in GameLoop.
        // Leave it like this, this is exactly what UI should be used for
        // - Alvin
        public void DisplayTurn(Player plr)
            {
            Line();
            Console.WriteLine($"{plr.Name}'s cards:");
            string[] cardNames = plr.ListCards();
            for (int i = 0; i < plr.CardsLeft(); i++)
            {
                Console.WriteLine($"Card {i + 1}: {cardNames[i]}");
            }
        }

        public string ColorPicker()
        {
            Console.Clear();
            while (true)
        {
                
                Console.WriteLine("Pick a color: Red, Green, Blue or Yellow");
                string color = Console.ReadLine().ToLower();
                switch (color)
            {
                    case "red":
                        return "Red";
                    case "green":
                        return "Green";
                    case "blue":
                        return "Blue";
                    case "yellow":
                        return "Yellow";
                    case "wild":
                        Console.WriteLine("Youve been a bad kitten for daddy. Come here and let me punish you with my thick, veiny, músky, sweaty, lengthy, girthy, HEAVY, 10.5 degrees left curved, MEATY, rock hard, iron-like, dripping, unwashed since the arab spring, cheese factory of a penis");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid color.");
                        break;
                }
            }
            }

        public string Interpreter()
        {
            Line();
            Console.WriteLine("Type the card you want to play (for example, Green 4)\nor pickup a card.");
            string input = Console.ReadLine().ToLower();
            
            return input;
        }
    }
}
