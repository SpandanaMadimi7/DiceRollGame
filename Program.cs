// See https://aka.ms/new-console-template for more information
// Task - 
// Roll The dice and get the number
// Ask for input
// check if the number is same as the input given by user
// 1st attempt - Same - Display you won text
// 2nd attempt - generate a new number and ask for an input and check if it is the same 
// 3rd attempt - if failed, Wrong Number - You lost!
// If no input given - display please enter the number. 
// If it is not number - display please enter a valid number.
using DiceRollGame;


CheckTheNumber startGame = new CheckTheNumber();
var count = 0;
do
{
    count++;
    var winOrLost = startGame.DiceRoll();
    if (winOrLost) break;
} while (count < 3);
Console.WriteLine("You Lost!");