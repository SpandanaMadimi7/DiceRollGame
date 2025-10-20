using GenerateNumber;

namespace DiceRollGame
{
    public class CheckTheNumber
    {
        ReadOrDisplay readOrDisplay = new ReadOrDisplay();
        public bool CheckingNumber(int number)
        {
            GenerateRandomNumber generate = new GenerateRandomNumber();
            var generatedNumber = generate.GenerateNumber();
            Console.WriteLine("Generated Number:" + generatedNumber);
            if (number == generatedNumber)
            {
                readOrDisplay.DisplayText("You Won!");
                return true;
            }
            else
            {
                readOrDisplay.DisplayText("Wrong Number");
                return false;
            }
        }
        
        public bool DiceRoll()
        {
                readOrDisplay.DisplayText("Enter a Number between 0 to 6");
                var input = readOrDisplay.TakeUserInput();
                var winOrLose = CheckingNumber(input);
            if (winOrLose) return true;
            return false;
        }
        
        }
    }