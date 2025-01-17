using SimonMemoryGameV2.Enum;

namespace SimonMemoryGameV2
{
    class SimonGame
    {
        private int _guessPosition = 0;

        public bool GameOver { get; private set; } = false;
        public List<Colors> ColorsList { get; private set; }

        public SimonGame()
        {
            ColorsList = new List<Colors>();
            GenerateColor();
        }

        public bool MakeGuess(Colors color)
        {
            if (ColorsList[_guessPosition] != color)
            {
                GameOver = true;
                return false;
            }
            else
            {
                if (_guessPosition == ColorsList.Count - 1)
                {
                    _guessPosition = 0;
                    GenerateColor();
                    return false;
                }
                _guessPosition++;
                return true;
            }
        }

        private void GenerateColor()
        {
            Random random = new Random();
            int randomColorAsInt = random.Next(0, 4);
            Colors randomColor = (Colors)randomColorAsInt;
            ColorsList.Add(randomColor);
        }

    }
}
