namespace SchoolUnoProject
{
    public class Player
    {
        public string Name { get; set; }
        private Deck Deck { get; set; }

        public Player(string name)
        {
            Name = name;
            Deck = new Deck();
        }

        public Card SelectCard(string cardname)
        {
            if (string.IsNullOrEmpty(cardname))
            {
                return null;
            }
            foreach (var card in Deck.ReadDeck())
            {
                if (card.Name.Equals(cardname, StringComparison.OrdinalIgnoreCase))
                {
                    Deck.RemoveCard(card);
                    return card;
                }
            }
            return null;
        }

        public string[] ListCards()
        {
            List<string> cardNames = new List<string>();
            foreach (var card in Deck.ReadDeck())
            {
                cardNames.Add(card.Name);
            }
            return cardNames.ToArray();
        }

        public void ReceiveCard(Card card)
        {
            Deck.AddCard(card);
        }

        public int CardsLeft()
        {
            return Deck.CardsCount();
        }
    }
}
