public class NumberGuessing
{
    public int max = 0;
    public int min = 0;
    public bool success;
    public int tries;
    public bool finished;
    //public string number;
    public int randomNum;
    public int playerGuess;
    // public string playAgain;

    // public void Intro()
    // {
    //     Console.WriteLine("Welcome to Guess It!");
    // }
    public void SetDifficulty()
    {
        //Set Difficulty
        Console.WriteLine("Please choose a difficulty level:");
        Console.WriteLine("1 - Easy (1-10)");
        Console.WriteLine("2 - Medium (1-50)");
        Console.WriteLine("3 - Hard (1-100)");
        Console.WriteLine("4 - Custom");
        string diffSet = Console.ReadLine();
        success = int.TryParse(diffSet, out int realDiffSet);

        while (success == false || realDiffSet >= 5 || realDiffSet <= 0)
        {
            Console.WriteLine("Error: Please input numbers 1-4");
            diffSet = Console.ReadLine();
            success = int.TryParse(diffSet, out realDiffSet);
        }
        if (realDiffSet == 1)
        {
            Console.WriteLine("You have chosen EASY! (1-10)");
            max = 11;
            min = 1;
        }
        else if (realDiffSet == 2)
        {
            Console.WriteLine("You have chosen MEDIUM! (1-50)");
            max = 51;
            min = 1;
        }
        else if (realDiffSet == 3)
        {
            Console.WriteLine("You have chosen HARD! (1-100)");
            max = 101;
            min = 1;
        }
        else if (realDiffSet == 4)
        {
            Console.WriteLine("You have chosen CUSTOM!");
            bool isConverted1 = false;
            bool isConverted2 = false;

            while (isConverted1 == false || isConverted2 == false)
            {
                Console.Write("Please set the MAXimum amount of numbers: ");
                string CUSmax = Console.ReadLine();
                Console.Write("Please set the MINimum amount of numbers: ");
                string CUSmin = Console.ReadLine();
                isConverted1 = int.TryParse(CUSmax, out max);
                isConverted2 = int.TryParse(CUSmin, out min);
                if (isConverted1 == false || isConverted2 == false)
                {
                    Console.WriteLine("Error: One of your numbers isn't a valid number. Try Again!");
                }
                else if (min > max)
                {
                    Console.WriteLine("Error: Your minimum number is higher than your maximum number. Try Again!");
                    isConverted1 = false;
                    isConverted2 = false;
                }
            }
        }
    }
    public void RandomNumSetup()
    {
        Random rnd = new Random();
        randomNum = rnd.Next(min, max);
    }
    public void StartGame()
    {
        tries = 1;
        finished = false;
        Console.Write("Guess your number here: ");
    }
    public void MakeGuess()
    {
        string number = Console.ReadLine();
        success = int.TryParse(number, out playerGuess);
        CheckGuess();
    }
    public void CheckGuess()
    {
        Console.WriteLine ("");
        if(success == false)
        {
            Console.Write("Error: Please input a valid number: ");
            MakeGuess();
        }
        else if (randomNum == playerGuess && tries == 1)
        {
            Console.WriteLine("WOW, you got it first try! NICE!");
            finished = true;
            // PlayAgain();
        }
        else if (randomNum == playerGuess && tries > 1)
        {
            Console.WriteLine($"You got it! It took you {tries} tries!");
            finished = true;
            // PlayAgain();
        }
        else if (randomNum < playerGuess)
        {
            Console.Write("Your number is too high! Try again: ");
            tries += 1;
            MakeGuess();
        }
        else if (randomNum > playerGuess)
        {
            Console.Write("Your number is too low! Try again: ");
            tries += 1;
            MakeGuess();
        }
    }
    // public string PlayAgain()
    // {
    //     Console.WriteLine("Would you like to play again? y/n");
    //     playAgain = Console.ReadLine().ToLower();

    //     while (playAgain != "y" && playAgain != "n")
    //     {
    //         Console.WriteLine("Error! Try Again!");
    //         PlayAgain();
    //     }

    //     return playAgain;

    // }//while(playAgain == "y");
}