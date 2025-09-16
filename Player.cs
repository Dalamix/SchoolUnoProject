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

        // Turn this int into a position inside of an array we can look up
        public Card PlayCard(string card_name)
        {
            if (string.IsNullOrEmpty(card_name))
            {
                return null;
            }
            foreach (var card in Deck.ReadDeck())
            {
                if (card.Name.Equals(card_name, StringComparison.OrdinalIgnoreCase))
                {
                    return card;
                }
            }
            return null;
        }

        public void RemoveCard(Card card)
        {
            Deck.RemoveCard(card);
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
