using System;

namespace dotnet1stConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // First testprogram day 1
            /*
             multiple comments.. to comment out testcode etc.
            */
            Console.WriteLine("Hello\nWorld!\n");
            Console.WriteLine("I love to code!\n");


            //Console.WriteLine("Whats your age");
            
            int intInput = GetInputFromUser("age");


            Console.WriteLine("\n\nYour age your typed in are: " + intInput);

            int userSelect;

            do
            {
                Console.WriteLine("----- Menu -----");


                Console.WriteLine("1: Code Joke");
                Console.WriteLine("2: Count down");
                Console.WriteLine("3: Ask Bartender for drink.");
                Console.WriteLine("9: Quit.");

                userSelect = GetInputFromUser("Menu selection");

                switch (userSelect)
                {
                    case 1:
                        Console.WriteLine("Why does java programmers have glasses?\nThey do not see sharp(C#)");
                        break;

                    case 2:
                        Console.WriteLine("Why does java programmers have glasses?\nThey do not see sharp(C#)");
                        break;

                    case 3:
                        Bartend();
                        break;

                    case 9:
                        Console.WriteLine("Thanks for using this program.");
                        Console.WriteLine("Press any key to close the program.");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Not valid");
                        break;
                }
            } while (userSelect != 9);
            
            

            Console.ReadKey();
        } // endtag main

        static int GetInputFromUser()
        {
            string userInput = Console.ReadLine();
            int number = 0;
            //int intAge = Int32.TryParse(userInput);
            int.TryParse(userInput, out number);

            return number;
        }

        static int GetInputFromUser(string forWhat)
        {
            Console.Write("\n\nEnter " + forWhat + " number: ");
            string userInput = Console.ReadLine();
            int number = 0;
            //int intAge = Int32.TryParse(userInput);
            int.TryParse(userInput, out number);

            return number;
        }

        static void Bartend()
            {
                if (intInput > 17)
                {
                Console.WriteLine("Here you go, a nice cold beer!");
                }
                else
                {
                Console.WriteLine("Your are not 18 or more, so here is a soda!");
                }
            }

    }
}
