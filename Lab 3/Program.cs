using System;

namespace Lab_3_Decision_Making_Using_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name? ");
            string name = (Console.ReadLine());
            int i = 0;
            while (i < 1 || i > 100)
            {


                Console.WriteLine("Please enter a number between 1 - 100. ");
                i = int.Parse(Console.ReadLine());


                // if (i % 2 != 0 || i > 100 && i < 1)
                if (i > 100 || i < 1)
                {
                    Console.WriteLine(name + ", " + "This is not a valid input. ");//* This is the line I cant seem to get printed out to the user.*
                }
            }
            if (i % 2 == 0 && i >= 26 && i <= 60) //checking if the number is even and larger than 26 but less than 60. Build Specs starts here.
            {
                Console.WriteLine(name + ", " + i + " is an even number between 26 and 60. ");
            }
            if (i % 2 == 0)
            {
                Console.WriteLine(name + ", " + i + " is an even number. ");
            }
            else if (i % 2 != 0)
            {
                Console.WriteLine(name + ", " + i + " is an odd number. ");
            }
            else if (i % 2 == 0 && i <= 25) //checking for even number less than 25
            {
                Console.WriteLine(name + ", " + i + " is even and less than 25. ");
            }
            else if (i % 2 == 0 && i > 60)
            {
                Console.WriteLine(name + ", " + i + " is an even number. ");
            }
            else if (i % 2 != 0 && i > 60)
            {
                Console.WriteLine(name + ", " + i + " is an odd number. "); // Build specs ends here.
            }
            else
            {
                Console.WriteLine(name + ", " + "that is not a valid input. ");
            }



        }
    }
}

