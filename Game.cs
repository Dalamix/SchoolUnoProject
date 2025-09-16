using SchoolUnoProject;

class Game
{
    Player[] players;
    UserInterface userInterface;
    TableDeck tableDeck;
    int playerCount;

    public Game(Player[] _players, UserInterface _userInterface, TableDeck _tableDeck)
    {
        players = _players;
        userInterface = _userInterface;
        tableDeck = _tableDeck;
        playerCount = players.Length;
    }

    public void DealCards()
    {
        for(int i = 0; i < playerCount; i++)
        {
            for(int j = 0; j < 7; j++)
            {
                GiveCard(players[i]);
            }
        }
    }

    public void GiveCard(Player player)
    {
        Card newCard = tableDeck.RandomCard();
        player.ReceiveCard(newCard);
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
        bool gameRunning = true;
        int playcount = players.Length;
        Card last_card = tableDeck.RandomCard();
        while (gameRunning)
        {
            for(int i = 0; i < playcount; i++)
            {
                Player player = players[i];
                Console.Clear();
                Console.WriteLine($"The last card played was {last_card.ToString()}");
                userInterface.DisplayTurn(player);

                while (true)
                {
                    string? input = userInterface.Interpreter(player);
                    if (input != "pickup" || input != "pick up")
                    {
                        Card played_card = player.PlayCard(input);
                        if (last_card.Color == "Wild" || (played_card.Color == last_card.Color || played_card.Type == last_card.Type))
                        {
                            player.RemoveCard(played_card);
                            last_card = played_card;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You can't play that card! Try again.");
                        }
                        
                    }
                    else if (input == "pickup" || input == "pick up")
                    {
                        GiveCard(player);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid command, please try again");
                    }
                }

                if (players[i].CardsLeft() == 0)
                {
                    gameRunning = false;
                    Console.WriteLine($"{players[i].Name} has won the game!");
                    break;
                }
            }
            
        }

    }

}