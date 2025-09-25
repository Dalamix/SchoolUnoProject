namespace SchoolUnoProject
{
    class Program
    {
        public static void Main()
        {
            while(true)
            {
                UserInterface userInterface = new UserInterface();
                TableDeck tableDeck = new TableDeck();
                Player[] players = userInterface.Start();
                Game game = new Game(players, userInterface, tableDeck);
                game.DealCards();
                game.GameLoop();
            }
            

        }
    }
}