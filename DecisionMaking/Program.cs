using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber;
            bool hasValidInt = false;
            bool toRun = true;

            //ask user for their name
            Console.WriteLine("What... is your name??");
            string userName = Console.ReadLine();
            //Main Loop
            while (toRun)
            {
                //Loop to verify a valid number has been entered. Using do-while to ensure the loop is enetered at least once upon arrival
                do
                {
                    //set the loop's boolean to false to make sure.
                    hasValidInt = false;
                    Console.WriteLine(userName + ", enter an integer between one and one hundred (1 & 100)!");
                    userNumber = int.Parse(Console.ReadLine());
                    if (userNumber >= 1 && userNumber <= 100)
                    {
                        //user has a valid number, proceed with the code!
                        hasValidInt = true;
                    }
                    else
                    {
                        //invalid number given
                        Console.WriteLine("This is not a valid number, " + userName);
                    }
                } while (!hasValidInt);
                //Check if Number is Even
                if (userNumber % 2 == 0)
                {
                    //number is even
                    if (userNumber >= 2 && userNumber <= 25)
                    {
                        Console.WriteLine(userName + ", your number is Even and less than 25.");
                    }
                    else if (userNumber >= 26 && userNumber <= 60)
                    {
                        Console.WriteLine(userName + ", your number is Even.");
                    }
                    else
                    {
                        Console.WriteLine(userName + ", your number is " + userNumber + " and Even.");
                    }
                }
                else
                {
                    //number is odd
                    if (userNumber > 60)
                    {
                        Console.WriteLine(userName + ", your number is " + userNumber + " and Odd.");
                    }
                    else
                    {
                        Console.WriteLine(userName + ", your number is " + userNumber + " and Odd.");
                    }
                }
                //check to see if the user wants to go again
                Console.WriteLine(userName + ", would you like to go again? (y/n)");
                string goAgain = Console.ReadLine().ToLower();
                if (goAgain == "n")
                {
                    //user does not want to go again, break the loop
                    toRun = false;
                }
            }

            //Goodbye!
            Console.WriteLine("Farewell, " + userName + "...");
        }
    }
}
