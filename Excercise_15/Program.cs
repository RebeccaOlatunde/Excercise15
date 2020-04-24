using System;

namespace Excercise_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
             {
                string answer;
                do
                {
                    bool valid;
                    string input;
                    int number;

                    do
                    {
                        Console.WriteLine("Please enter your number");
                        input = Console.ReadLine();

                        valid = int.TryParse(input, out number);
                    }
                    while (valid == false);

                    for (int i = 1; i <= number; i++)
                    {

                        Console.WriteLine(i * i * i);

                    }

                    Console.WriteLine("Continue ? (y / n)");
                    answer = Console.ReadLine().ToUpper();

                }
                while (answer == "Y");

                Console.WriteLine("Goodbye!");
            }
        }
    }
}
