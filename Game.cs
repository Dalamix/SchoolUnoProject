using SchoolUnoProject;

class Game
{
    Player[] players;
    UserInterface userInterface;

    public Game(int playcount, UserInterface _userinterface)
    {
        players = new Player[playcount];
        userInterface = _userinterface;
    }

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

    public void GameLoop()
    {
        // while no player has won
        // for each player in players
        //      player.Turn()
        //      if player.Deck.CardsLeft() == 0
        //          player has won!
        // ram ranch femboys
        // femboys are cute <3

        // femboys are hugging us with love! We love femboys!
        bool gameRunning = true;
        int playcount = players.Length;
        while (gameRunning)
        {
            for(int i = 0; i < playcount; i++)
            {
                // players[i].Turn();
                Player player = players[i];
                userInterface.CardUsage(player);
                if (players[i].Deck.CardsLeft() == 0)
                {
                    gameRunning = false;
                    Console.WriteLine($"{players[i].Name} has won the game!");
                    break;
                }
            }
            // ram ranch femboys 
        }

    }

}