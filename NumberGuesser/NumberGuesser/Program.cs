using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Sajid";


            //Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}",name);


            Console.WriteLine("What is your Name?");

            string input0 = Console.ReadLine();

            Console.WriteLine("Hello {0}, Let's play a game....", input0);


            while (true)
            {


                //int correctNumber = 7;

                //Create a new random object
                Random random = new Random();

                //set auto generate correct number
                int correctNumber = random.Next(1, 10);


                // innit guess var
                int guess = 0;


                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 11");

                //while guess is wrong
                while (guess != correctNumber)
                {

                    //get user input(currently a string) 
                    string input = Console.ReadLine();

                    //make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter actual  Number");
                        Console.ResetColor();
                        continue;
                    }


                    //parse to an interger and put in guess
                    guess = Int32.Parse(input);

                    //match guess to correct number
                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong Number, try again");
                        Console.ResetColor();
                    }
                }

                //need to go ouside of the above while loop, cause now guess is going to be equal to the correct number

                //Output success Message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You are Correct!");
                Console.ResetColor();


                //ask to play again
                Console.WriteLine("Play again [Y or N]");

                //get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }

                else if (answer == "N")
                {
                    return;
                }

                else
                {
                    return;
                }


            }
           

        }
    }
}
