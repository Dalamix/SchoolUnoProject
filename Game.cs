using SchoolUnoProject;

public class Game
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