using System;
using System.Runtime.CompilerServices;

namespace lab3_07212020_decisionmaking
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            //valid is for validating number range 1-100
            bool valid = false;
            //cont is for continuing the game
            string cont="";
            Console.WriteLine("Hello there!! It is I, the magnificent number magician! I can tell you many wonderous things about numbers, just by seeing them!");
            Console.WriteLine("If I may ask, to whom do I have the pleasure of speaking to?");
            //receive the user's name, stored in name
            string name = Console.ReadLine();
            while (cont.ToUpper() != "N")
            {
                Console.WriteLine("Excellent! Nice to meet you " + name + "! Pick a number! Any number! Well, any number between 1 and 100! That's....the only numbers I know so far.");
                while (!valid)
                {
                    //this loop garuntees only valid inputs (int and in range (1-100)).
                    while (!int.TryParse(Console.ReadLine(), out input))
                    {
                        Console.WriteLine(name + ", I might be magnificent, but....I don't know that number. Please give me a number between 1-100!");
                    }
                    if (1 <= input && 100 >= input)
                    {
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("I said BETWEEN 1-100, " + name + "!");
                    }
                }
                int oddcheck = input % 2;
                switch (oddcheck)
                {
                    case 0:
                        {
                            if (input < 25)
                            {
                                Console.WriteLine("Your number is not only even, but it is less than 25! I bet your impressed, " + name + "!");
                            }
                            else if (input <= 60)
                            {
                                Console.WriteLine("Your number is even! It's true, " + name + "! You can look it up!");
                            }
                            else
                            {
                                Console.WriteLine(name + ", your number is even and it is " + input + "!");
                            }
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Oh ho!! Marvel at my genius! Your number is not only odd, but it is in fact " + input + "!");
                            break;
                        }
                }
                Console.WriteLine("How was that? Would you like to play again (Pssst! Y/N answers only please)?");
                while (valid)
                {//both valid answers Y and N will break loop.
                    cont = Console.ReadLine();
                    switch (cont.ToUpper())
                    {
                        case "Y":
                            {
                                Console.WriteLine("Wondeful! Let's see another number!");
                                valid = false;
                                break;
                            }
                        case "N":
                            {//When cont = N while loop for entire program will terminate.
                                Console.WriteLine("Alright! Have a great day " + name + "!");
                                valid = false;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("I'm sorry; I didn't hear you; What was that? Did you want to play again (Y/N)?");
                                break;
                            }
                    }
                }
            
            }
        }
    }
}






