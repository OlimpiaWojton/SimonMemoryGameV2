using SimonMemoryGameV2.Enum;

namespace SimonMemoryGameV2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                SimonGame game = new SimonGame();

                while (!game.GameOver)
                {
                    DisplayCurrentRound(game);
                    Colors color;
                    do
                    {
                        Console.WriteLine("Enter color: ");
                        string? colorAsString = Console.ReadLine();
                        color = StringToColorConverter.Convert(colorAsString);
                    } while (game.MakeGuess(color));
                }

                Console.WriteLine("Game over");
            } while (PlayAgain());

        }
        private static void DisplayCurrentRound(SimonGame game)
        {
            Console.Clear();

            foreach (Colors color in game.ColorsList)
            {
                Console.WriteLine("Round " + game.ColorsList.Count + ":\n");

                Thread.Sleep(1000);

                switch (color)
                {
                    case Colors.Green:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Colors.Red:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Colors.Blue:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case Colors.Yellow:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                }

                Console.WriteLine(color);
                Thread.Sleep(1000);
                Console.Clear();
                Console.ResetColor();
            }
            Console.WriteLine("Round " + game.ColorsList.Count + ":\n");
        }

        private static bool PlayAgain()
        {
            Console.WriteLine("\nIf you want to play again press \" Y \" if not press another button");
            string response = Console.ReadLine().ToUpper();
            if (response == "Y")
            {
                return true;
            }
            return false;
        }
    }
}
