using System;

namespace WhileIteration
{
    class Program
    {

        static void Exit()
        {
            Environment.Exit(1);
        }
        static void Main(string[] args)
        {
            MainMenu();

            Console.ReadLine();
        }

        private static void MainMenu()
        {
            Console.WriteLine("1) Start GuessingGame");
            Console.WriteLine("2) Exit");
            int option = int.Parse(Console.ReadLine());
            Console.Clear();
            if (option == 1)
            {
                Console.Clear();
                GuessingGame();
            }
            else if (option == 2)
            {
                Exit();
            }
            else
            {
                Exit();
            }
        }

        private static void GuessingGame()
        {
            Console.WriteLine("This is guessing game. \nWe drew one number from 1 to 10 and you must guess it. Go for it!" );
            Random rd = new Random();
            int rand_num = rd.Next(1, 11);

            int counter = 0;
            bool guessing = true;
            do
            {
               Console.Write("Your number: ");
                int number = int.Parse(Console.ReadLine());
                if (number == rand_num)
                {
                    counter++;
                    Console.WriteLine("You won!");
                    Console.WriteLine("It took " + counter + " guesses.");
                    guessing = false;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                    counter++;
                }
             } while (guessing);

            bool wybor = true;
            do
            {
                Console.WriteLine("\nWhat do you want to do?");
                Console.WriteLine("1) Exit to Main Menu");
                Console.WriteLine("2) Play again!");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Clear();
                    MainMenu();
                    wybor = false;
                }
                else if (option == 2)
                {
                    wybor = false;
                    Console.Clear();
                    GuessingGame();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("I dont understand.");
                }
            } while (wybor);

        }
    }
}
