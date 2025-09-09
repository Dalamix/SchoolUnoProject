namespace SchoolUnoProject
{
    public class Deck
    {
        private List<Card> list;
        public Deck()
        {
            list = new List<Card>();
        }
        public List<Card> ReadDeck()
        {
            return list;
        }
        public void AddCard(Card card)
        {
            list.Add(card);
        }
        public void RemoveCard(Card card)
        {
            list.Remove(card);
        }
        public void PickupCard()
        {
            list.Add(new Card());
        }
    }
}
