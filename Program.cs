namespace SchoolUnoProject
{
    public class variables
    {

    }

    class Game
    {
        
    }

    class player
    {
        public player()
        {
            
        }

    }

    class program
    {
        
        public static void Main()
        {
            bool playernumber = false;
            bool start = false; 
            if(Console.ReadLine() == "start".ToLower())
            {
                start = true;
            }
            else
            {
                Console.WriteLine("go fuck yourself");
            }
            Console.WriteLine("How many players do you want");
            playernumber = int.TryParse(Console.ReadLine(), out int playercount);
        }
    }
}
