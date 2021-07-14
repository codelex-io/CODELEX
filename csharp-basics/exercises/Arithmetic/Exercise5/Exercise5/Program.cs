using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101);
            bool isTrue = true;

            Console.Write("Enter number from 1 to 100: ");
            string input = Console.ReadLine();
            char[] inputToCharArray = input.ToCharArray();

            for(int i = 0; i < inputToCharArray.Length; i++)
            {
                if(!Char.IsDigit(inputToCharArray[i]))
                {
                    Console.Write("Wrong input!!!\n");
                    Console.ReadKey();
                    isTrue = false;
                    break;
                }     
            }

            if(isTrue)
            {
                int inputToInt = Convert.ToInt32(input);

                if(inputToInt < 1 || inputToInt > 100)
                {
                        Console.Write("Wrong input!!!\n");
                } else
                {
                    if(inputToInt == randomNumber)
                    {
                        Console.WriteLine("You guessed it!  What are the odds?!?");
                    }

                    if(inputToInt > randomNumber)
                    {                  
                        Console.WriteLine($"Sorry, you are too high.  I was thinking of {randomNumber}.");
                    }

                    if(inputToInt < randomNumber)
                    {
                        Console.WriteLine($"Sorry, you are too low.  I was thinking of {randomNumber}.");
                    }
                }

                Console.ReadKey();
            }
        }
    }
}
