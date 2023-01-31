
namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNum = new Random();
            int compNum = randomNum.Next(1, 101);
            while (true) 
            {
                Console.Write("Guess The Number (1 - 100) :");
                string playerNum = Console.ReadLine();
                bool isValid = int.TryParse(playerNum, out int playerNumber);
                if (isValid)
                {
                    if (playerNumber == compNum)
                    {
                        Console.WriteLine("You guessed it!");
                        break;
                    }
                    else if (playerNumber > compNum)
                    {
                        Console.WriteLine("Too high!");
                    }
                    else
                    {
                        Console.WriteLine("Too low");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid!");
                }
            }
        }
    }
}