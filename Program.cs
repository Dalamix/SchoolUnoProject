namespace SchoolUnoProject
{
    class Program
    {
        public static void Main()
        {
            UserInterface userInterface = new UserInterface();
            TableDeck tableDeck = new TableDeck();
            Player[] players = userInterface.Start();
            Game game = new Game(players, userInterface, tableDeck);

            game.GameLoop();

        }
    }
}