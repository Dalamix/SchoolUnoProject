namespace SchoolUnoProject
{
    public class Card
    {
        private Random random = new Random();

        private char[] Colors =
        {
            'R', 'G', 'B', 'Y', 'W'
        };
        private string[] Types =
        {
            "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "+2", "Blk", "Rev", "+4", "Col"
        };

        public char Color;
        public string Type;
        public string Name;
        public bool? Special;

        // Creating a card object will randomly select color and type
        public Card()
        {
            Type = Types[random.Next(Types.Length)];
            Special = (!Char.IsNumber(Type[0])) ? true : false;
            // We cant have a wildcard 6, it needs to be a special (+4 or color switch)
            if (Special == true && (Type == "+4" || Type == "Col"))
            {
                Color = 'W';
            }
            else
            {
                Color = Colors[random.Next(Colors.Length - 4)];
            }
            Name = Color.ToString() + " " + Type;
        }

        public Card(char color, string type, bool special)
        {
            Type = type;
            Special = (!Char.IsNumber(Type[0])) ? true : false;
            // We cant have a wildcard 6, it needs to be a special (+4 or color switch)
            if (Special == true && (Type == "+4" || Type == "Col"))
            {
                Color = 'W';
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
