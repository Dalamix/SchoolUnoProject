using SchoolUnoProject;

class Game
{
    Player[] players;
    UserInterface userInterface;
    TableDeck tableDeck;
    int playerCount;
    int playerIndex;
    Rules rules;

    public Game(Player[] _players, UserInterface _userInterface, TableDeck _tableDeck)
    {
        players = _players;
        userInterface = _userInterface;
        tableDeck = _tableDeck;
        playerCount = players.Length;
        rules = userInterface.rules;
        playerIndex = 0;
    }

    private void IncreaseIndex()
    {
        playerIndex++;
        if (playerIndex >= playerCount)
        {
            playerIndex = 0;
        }
    }

    private void DecreaseIndex()
    {
        playerIndex--;
        if (playerIndex < 0)
        {
            playerIndex = playerCount - 1;
        }
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

    public void GiveCard(Player player, int amount)
    {
        for(int i = 0; i < amount; i++)
        {
            GiveCard(player);
        }
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
        string wild_choice = null;
        bool blocked = false;
        while (gameRunning)
        {
            for(playerIndex = 0; playerIndex < playcount; IncreaseIndex())
            {
                Player player = players[playerIndex];
                Console.Clear();
                if (player.CardsLeft() > 1)
                {
                    player.CalledUno = false;
                }
                if (wild_choice != null)
                {
                    Console.WriteLine($"The last card played was {last_card.ToString()} and the color is now {wild_choice}.");
                } 
                else
                {
                    Console.WriteLine($"The last card played was {last_card.ToString()}");
                }
                
                if (blocked == true)
                {
                    Console.WriteLine($"{player.Name} has been blocked and loses their turn!");
                    Console.ReadLine();
                    blocked = false;
                    continue;
                }
                userInterface.DisplayTurn(player);
                while (true)
                {
                    string? input = userInterface.Interpreter();
                    if (input == "pickup" || input == "pick up")
                    {
                        GiveCard(player);

                        Console.Clear();
                        if (wild_choice != null)
                        {
                            Console.WriteLine($"Picked up a card!\nThe last card played was {last_card.ToString()} and the color is now {wild_choice}.");
                        }
                        else
                        {
                            Console.WriteLine($"Picked up a card!\nThe last card played was {last_card.ToString()}");
                        }
                        player.CalledUno = false;
                        userInterface.DisplayTurn(player);
                        continue;
                    }
                    else if (input == "uno")
                    {
                        DecreaseIndex();
                        if (players[playerIndex].CardsLeft() == 1)
                        {
                            Console.WriteLine($"{players[playerIndex].Name} failed to call UNO and must pick up 2 cards!");
                            GiveCard(players[playerIndex], 2);
                        }
                        IncreaseIndex();
                        if (players[playerIndex].CardsLeft() == 2)
                        {
                            player.CalledUno = true;
                            Console.WriteLine($"{player.Name} called UNO!");
                        }
                        else if (input == "uno" && player.CardsLeft() != 2)
                        {
                            Console.WriteLine("You can only call UNO when you have 2 cards left!");
                        }
                    }
                    else if (input != "pickup" || input != "pick up")
                    {
                        Card played_card = player.PlayCard(input);
                        if (played_card == null)
                        {
                            Console.WriteLine("You don't have that card! Try again.");
                        }
                        else if (played_card.Color == "Wild" || (played_card.Color == last_card.Color || played_card.Type == last_card.Type))
                        {
                            player.RemoveCard(played_card);
                            last_card = played_card;
                            if (last_card.Type == "Color")
                            {
                                wild_choice = userInterface.ColorPicker();
                            }
                            else if (last_card.Type == "+4")
                            {
                                wild_choice = userInterface.ColorPicker();
                                GiveCard(players[(playerIndex + 1) % playcount], 4);
                                blocked = true;
                            }
                            else if (last_card.Type == "+2")
                            {
                                GiveCard(players[(playerIndex + 1) % playcount], 2);
                                blocked = true;
                            }
                            else if (last_card.Type == "Reverse")
                            {
                                Array.Reverse(players);
                                playerIndex = playcount - playerIndex;
                                DecreaseIndex();
                            }
                            else if (last_card.Type == "Block")
                            {
                                IncreaseIndex();
                            }
                            break;
                        }
                        else if (played_card.Color == wild_choice && played_card.Color != "Wild")
                        {
                            wild_choice = null;
                            player.RemoveCard(played_card);
                            last_card = played_card;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You can't play that card! Try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid command, please try again");
                    }
                }

                if (players[playerIndex].CardsLeft() == 0)
                {
                    gameRunning = false;
                    Console.WriteLine($"{players[playerIndex].Name} has won the game!");
                    break;
                }
            }
            
        }

    }

}