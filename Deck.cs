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
        public int CardsCount()
        {
            return list.Count;
        }
        public void AddCard(Card card)
        {
            list.Add(card);
        }
        public void RemoveCard(Card card)
        {
            list.Remove(card);
        }
        public void PickCard()
        {
            list.Add(new Card());
        }
    }
}
