namespace SchoolUnoProject
{
    class Program
    {
        public static void Main()
        {
            UserInterface userinterface = new UserInterface();
            int playercount = userinterface.Start();
            if (playercount != 2 || playercount != 3 || playercount != 4)
            {
                return;
            }

            for(int i = 0; i <= playercount; i++)
            {
                Deck deck = new Deck();
                players[i].Deck = deck;
            }
        }
    }
}