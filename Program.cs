using System;


namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo(); //app info

            GreetUser();  //greet user 

            //start of app
            

            while (true)
            {



                //set number
                //int correctNumber = 7;
                Random random = new Random();

                int correctNumber = random.Next(1, 10);


                //guess
                int guess = 0;

                //text to showing intrustruction
                Console.WriteLine("Guess a number");

                //while guess is not correct

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {

                        PrintColorMessage(ConsoleColor.Red, "Please Enter a number");

                        //keep going
                        continue;
                    };

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        //Change color to red
                        PrintColorMessage(ConsoleColor.Red, "Wrong answr");  

                    };


                }

                //for right answer
                Console.ForegroundColor = ConsoleColor.Yellow;

                //out put write answer
                Console.WriteLine("You guessed right answer is {0}", correctNumber);

                //reset the color
                Console.ResetColor();

                //ask to play again
                Console.WriteLine("Play again [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if(answer== "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            //set app variable
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string author = "Igbadumhe perfect";
            //console color
            Console.ForegroundColor = ConsoleColor.Yellow;


            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, author);
            //reset color
            Console.ResetColor();

        }

        static void GreetUser()
        {
            Console.WriteLine("Pls enter your name");

            //input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
