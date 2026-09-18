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

Console.WriteLine("");
Console.WriteLine("Thanks for playing!");