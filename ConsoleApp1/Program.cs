using System;

namespace Dungeons {
    class Program
    {
        static void Main(string[] args) //this is a method called "Main". It is called when the program starts
        {
            GreetUser();
            WriteOutput();
            Console.ReadKey();
        
        }
        
        static void GreetUser() //Method: Greetings
        {
            Console.WriteLine("Hello there brave adventurer, pray tell, what is your name?");
        }

        public static string WaitForUserInput( ) //Method: Wait for user's answer
        {
            return Console.ReadLine();
        }

        public static void WriteOutput() //Method: Reply
        {
            string name = WaitForUserInput();
            Random RNG = new Random();
            int dice = RNG.Next(1, 11);
            switch (dice)
            {
                case 1:
                    Console.WriteLine("Ah, the name of a hero!");
                    break;
                case 2:
                    Console.WriteLine("That's my grand mother's name");
                    break;
                case 3:
                    Console.WriteLine("From now on you shall be known as FRUUU FRUU!");
                    break;
                default:
                    Console.WriteLine("pleased to meet you ," + name);
                    break;
            }
        }
       
        public static int Add(int num01, int num02)
        {
            return num01 + num02;
        }
        

    }
}
