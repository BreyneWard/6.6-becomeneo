namespace _6._6_becomeneo;
class Program
{
    
    static void Main(string[] args)
    {
        Random rangen = new Random();
        Console.ForegroundColor = ConsoleColor.Green;

        while(true)
        {
            char teken = Convert.ToChar(rangen.Next(62, 400));
            Console.ForegroundColor = GetRandomConsoleColor();
            Console.Write(teken);

            // 10 ms pauze tussen ieder frame 
            System.Threading.Thread.Sleep(10);

            if(rangen.Next(0,3) == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }
    }

    static ConsoleColor GetRandomConsoleColor()
    {
        Random randomColour = new Random();
        var consoleColors = Enum.GetValues(typeof(ConsoleColor));
        return (ConsoleColor)consoleColors.GetValue(randomColour.Next(consoleColors.Length));
    }
}
