using System;

namespace Modul2
{
    class Program
    {
        // Dessa variabler behövs inte, för du har skapat lokala i main. 
        //STEG 1 definiera variabler du ska använda
        static string name = "";
        static int age;
        static char letter;

        //STEG 2 definiera metoder som behövs
        static void Main(string[] args)
        {
            AskForInformation();
            ReturnInformation();
        }

        //STEG 3 
        public static void AskForInformation() // Skulle göra en metod med ett namn som mer visar vad man gör. 
        {

            Console.Write("What is your name? ");
            name = Console.ReadLine();
            // Lokal variabel. 
            Console.Write("How old are you? ");
            age = int.Parse(Console.ReadLine());

            Console.Write("What is your favorite letter? ");
            letter = char.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Thank you!");
            Console.WriteLine();

            // Här kan du göra en ny metod som kallas ex. ReturningInput(). 

        }
        public static void ReturnInformation()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Your name is: " + name);
            Console.WriteLine("Your age is: " + age);
            Console.WriteLine("Your favorite letter is: " + age);
            Console.WriteLine();

        }
    }
}
