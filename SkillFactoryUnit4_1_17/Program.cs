using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Your favorite color?");

        var color = Console.ReadLine();

        if (color == "yellow")
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is yellow!");
        }

        else if (color == "green")
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is green!");
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("No no no. I'm sure your favorite color is yellow!");
        }
    }
}