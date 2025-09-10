namespace SchoolUnoProject
{
    public class UserInterface
    {
        // Variables
        private Player CurrentPlayer { get; set; }
        public Game Game { get; set; } // Reference to game because we need it

        // Player commands

        // Start the game and send relevant info to Game
        public void Start()
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
            // TODO: Create players and pass to Player class

            // TODO: Add ability to decide house rules
            bool[] rules; 
            while(true)
            {
                break;
            }

            while(true) 
            {
                Console.WriteLine("\n==========\nConfirm, are these rules correct? (Y/N)");
                Console.WriteLine($"Players: {playerCount}\n");
                string? confirm = Console.ReadLine().ToLower();
                if (confirm == "n")
                {
                    Start();
                    return;
                }
                else if (confirm != "y" || string.IsNullOrEmpty(confirm))
                {
                    Console.WriteLine("\nInvalid answer.");
                }
                else
                {
                    break;
                }
            }
            // TODO: implement into actual game class
            Game?.SetRules(rules);

            Console.WriteLine($"Game started!");
        }

        public void Input()
        {
            int choice;
            while (true)
            {
                Console.WriteLine("\nDecide your next move:\n1. Play a card\n2. Pick up new cards\n3. Call UNO!");
                if (int.TryParse(Console.ReadLine(), out choice) && choice > 0 && choice <= 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again");
                }
            }
            switch (choice)
            {
                case 1:
                    PlayCard();
                    break;
                case 2:
                    Pickup();
                    break;
                case 3:
                    CallUno();
                    break;
            }
            
        }

        public void Pickup(Player player)
        {
            
        }


        public void PlayCard()
        {
            Console.WriteLine("Player's cards:");
            //for(int i = 0; i < player.ListCards().Length; i++)
            //{
            //    Console.WriteLine($"Card {i+1}");
            //}
            Console.WriteLine("Type the name of the card you want to play:");
            string playerinput = Console.ReadLine();
            while (playerinput == null)
            {
                Console.WriteLine("Invalid card name, please try again:");
                playerinput = Console.ReadLine();
            }
            Console.WriteLine("Card played!");
        }

        public void CallUno()
        {

        }

        // UI methods

        public void UpdateDeck()
        {

        }

        public void DisplayDeck()
        {

        }

        // Wrappers for Game class
    
        public void AdvanceTurn()
        {
            Game?.AdvanceTurn();
        }

        public void FinishGame()
        {
            Game?.FinishGame();
        }
    }
}
