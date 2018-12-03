using System;

namespace Modul2
{
    class Program
    {
        //STEG 1 definiera variabler du ska använda
        static string name = "";
        static int age;
        static char letter;

        //STEG 2 definiera metoder som behövs
        static void Main(string[] args)
        {
            AskForUsersName();
        }

        //STEG 3 
        public static void AskForUsersName()
        {

            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            
            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("What is your favorite letter? ");
            char letter = char.Parse(Console.ReadLine()); 

            Console.WriteLine();
            Console.WriteLine("Thank you!");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Your age is: " + age);
            Console.WriteLine("Your favorite letter is: " + letter);
            Console.WriteLine();
        }

    }
}
