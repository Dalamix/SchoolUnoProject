namespace SchoolUnoProject
{
    public class Card
    {
        private Random random = new Random();

        private string[] Colors =
        {
            "Red", "Green", "Blue", "Yellow", "Wild"
        };
        private string[] Types =
        {
            "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "+2", "Block", "Reverse", "+4", "Color"
        };

        public string Color;
        public string Type;
        public string Name;
        public bool? Special;

        // Creating a card object will randomly select color and type
        public Card()
        {
            Type = Types[random.Next(Types.Length)];
            Special = (!Char.IsNumber(Type[0])) ? true : false;
            // We cant have a wildcard 6, it needs to be a special (+4 or color switch)
            if (Special == true && (Type == "+4" || Type == "Color"))
            {
                Color = "Wild";
            }
            else
            {
                Color = Colors[random.Next(Colors.Length - 4)];
            }
            Name = Color.ToString() + " " + Type;
        }

        public Card(string color, string type, bool special)
        {
            Type = type;
            Special = (!Char.IsNumber(Type[0])) ? true : false;
            // We cant have a wildcard 6, it needs to be a special (+4 or color switch)
            if (Special == true && (Type == "+4" || Type == "Color"))
            {
                Color = "Wild";
            }
            else
            {
                Color = color;
            }
            Name = Color.ToString() + " " + Type;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
