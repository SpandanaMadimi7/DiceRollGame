namespace DiceRollGame
{
    public class ReadOrDisplay
    {
        public int TakeUserInput()
        {
            string userInput = Console.ReadLine();
            bool result = int.TryParse(userInput, out int input);
            if (string.IsNullOrEmpty(userInput) || !result || (!(input > 0 && input <= 6)))
            {
                DisplayText("Enter Valid Number between 0 to 6");
                TakeUserInput();
            }
            return input;
        }
        public void DisplayText(string text)
        {
            Console.WriteLine(text);
        }
    }
}