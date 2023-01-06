namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game !!");

            const int StartPosition = 0;
            const int WinningPosition = 100;
            int PlayerPosition = 0;
            int diceRollCount = 0;
            int diceRoll;


            Console.WriteLine("\nPress ENTER to Play the game");
            string play = Console.ReadLine();
            Console.WriteLine($"Player is at position {PlayerPosition}");

            Random random = new Random();
            while (PlayerPosition < WinningPosition)
            {
                diceRoll = random.Next(1, 7);
                Console.WriteLine($"\nPlayer rolled number {diceRoll} on position {PlayerPosition}");
                diceRollCount++;
                int option = random.Next(1, 3);
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Player landed on a Ladder");
                        PlayerPosition += diceRoll;
                        Console.WriteLine($"Player moves to position {PlayerPosition}");
                        if (PlayerPosition > WinningPosition)
                        {
                            PlayerPosition = PlayerPosition - diceRoll;
                            Console.WriteLine($"Player remains in position {PlayerPosition}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Player landed on a Snake");
                        PlayerPosition -= diceRoll;
                        Console.WriteLine($"Player moves to position {PlayerPosition}");
                        if (PlayerPosition < 0)
                        {
                            Console.WriteLine("No Play, Try Again");
                            PlayerPosition = 0;
                        }
                        break;
                }
            }
            if (PlayerPosition == 100)
            {
                Console.WriteLine("\n==========Player Wins==========");
            }
            Console.WriteLine($"\nDice was played {diceRollCount} times to win the game");
            Console.ReadLine();
        }
    }
}