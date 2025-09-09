namespace SchoolUnoProject
{
    public class Player
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }

        public Player(string name)
        {
            Name = name;
        }
    }
}
