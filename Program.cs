//Zionn Showers
//9-15-2026
//Challenge #2 - Guess It
/*I made the user choose a difficulty by pressing one of the 4 numbers (1-Easy, 2-Medium, 3-Hard, 4-Custom). 1 sets maximum number to 10, 2 to 50, and 3 to 100. All
the minimum numbers stay as 1. If 4 is chosen, then the user is able to change to minimum and maximum range the program randomly chooses. The game then starts, asking
the user to input a number. If the number inputted is too high or too low to the random number picked by the program, it will tell them how far they are. If the number
inputted is the same as the program's chosen number, the game ends. If they found the number on their first try, the program will write a special message to them to 
congradulate them. If they found the number after more than 1 try, the program will them how many tries it took them to find it. Afterwards, the program will ask them
if they want to play again. If they say yes, the game will restart. But if they say no, the game will say goodbye and finish running.*/
//Peer Review: Callen Thomason
/*
Program runs as intended and the games play very well. 
On the custom you can set a min that is higher than the max and it causes a runtime error
You are also allowed to guess numbers that are above and below the constraints. Might be nice for users if you didn't allow that
If statements to set min and maxs are very well made. Switch statement would have also worked nicely here
Flow chart looks really good, and your code follows it nicely
All your validation is great! 
Your welcome and thanks for playing are a nice touch.
*/

Console.Clear();

NumberGuessing NumGuess = new NumberGuessing();

Console.WriteLine("Welcome to Guess It!");

string playAgain;
do
{
Console.WriteLine ("");

NumGuess.SetDifficulty();
NumGuess.RandomNumSetup();
Console.WriteLine ("");
NumGuess.StartGame();
NumGuess.MakeGuess();

//play again
Console.WriteLine ("Would you like to play again? y/n");
playAgain = Console.ReadLine().ToLower();

while(playAgain != "y" && playAgain != "n")
{
    Console.WriteLine("Error! Try Again!");
    playAgain = Console.ReadLine().ToLower();
}

}while(playAgain == "y");
// }while(playAgain == "y");
// NumGuess.CheckGuess();

// while (NumGuess.playerGuess != NumGuess.randomNum)
// {
    // bool didConvert = NumGuess.MakeGuess();

    // if(didConvert == true)
    // {
    //     NumGuess.CheckGuess();
    // }
    // else
    // {
    //     Console.WriteLine("You didn't enter a number! Try again!");
    // }
// }



// Random rnd = new Random();

// int max = 0;
// int min = 0;

// Console.WriteLine("Welcome to Guess It!");

// string playAgain;
// do
// {

// Console.WriteLine("Please choose a difficulty level:");
// Console.WriteLine("1 - Easy (1-10)");
// Console.WriteLine("2 - Medium (1-50)");
// Console.WriteLine("3 - Hard (1-100)");
// Console.WriteLine("4 - Custom");
// string diffSet = Console.ReadLine();
// bool success = int.TryParse(diffSet, out int realDiffSet);

// while (success == false || realDiffSet >= 5 || realDiffSet <= 0)
// {
//     Console.WriteLine("Error: Please input numbers 1-4");
//     diffSet = Console.ReadLine();
//     success = int.TryParse(diffSet, out realDiffSet);
// }
// if(realDiffSet == 1)
// {
//     Console.WriteLine("You have chosen EASY! (1-10)");
//     max = 11;
//     min = 1;
// }
// else if(realDiffSet == 2)
// {
//     Console.WriteLine("You have chosen MEDIUM! (1-50)");
//     max = 51;
//     min = 1;
// }
// else if(realDiffSet == 3)
// {
//     Console.WriteLine("You have chosen HARD! (1-100)");
//     max = 101;
//     min = 1;
// }
// else if(realDiffSet == 4)
// {
//     Console.WriteLine("You have chosen CUSTOM!");
//     bool isConverted1 = false;
//     bool isConverted2 = false;

//     while (isConverted1 == false || isConverted2 == false)
//     {
//         Console.Write("Please set the MAXimum amount of numbers: ");
//         string CUSmax = Console.ReadLine();
//         Console.Write("Please set the MINimum amount of numbers: ");
//         string CUSmin = Console.ReadLine();
//         isConverted1 = int.TryParse(CUSmax, out max);
//         isConverted2 = int.TryParse(CUSmin, out min);
//         if (isConverted1 == false || isConverted2 == false)
//             {
//                 Console.WriteLine("Error: One of your numbers isn't a valid number. Try Again!");
//             }
//         else if (min > max)
//             {
//                 Console.WriteLine("Error: Your minimum number is higher than your maximum number. Try Again!");
//                 isConverted1 = false;
//                 isConverted2 = false;
//             }
//     }
// }

// int randomNum = rnd.Next(min, max);


// int tries = 1;
// bool finished = false;

// Console.Write("Guess your number here: ");

// do
// {

// string number = Console.ReadLine();
// success = int.TryParse(number, out int playerGuess);

// while(success == false)
// {
//     Console.Write("Error: Please input a valid number: ");
//     number = Console.ReadLine();
//     success = int.TryParse(number, out playerGuess);
// }
// if(randomNum == playerGuess && tries == 1)
// {
//     Console.WriteLine("WOW, you got it first try! NICE!");
//     finished = true;
// }
// else if(randomNum == playerGuess && tries > 1)
// {
//     Console.WriteLine($"You got it! It took you {tries} tries!");
//     finished = true;
// }
// else if(randomNum < playerGuess) 
// {
//     Console.Write("Your number is too high! Try again: ");
//     tries += 1;
// }
// else if(randomNum > playerGuess)
// {
//     Console.Write("Your number is too low! Try again: ");
//     tries += 1;
// }

// }while(finished == false);


// Console.WriteLine ("Would you like to play again? y/n");
// playAgain = Console.ReadLine().ToLower();

// while(playAgain != "y" && playAgain != "n")
// {
//     Console.WriteLine("Error! Try Again!");
//     playAgain = Console.ReadLine().ToLower();
// }

// }while(playAgain == "y");

// Console.WriteLine("Thanks for playing!");