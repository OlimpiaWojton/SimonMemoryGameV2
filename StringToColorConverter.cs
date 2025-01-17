using SimonMemoryGameV2.Enum;

namespace SimonMemoryGameV2
{
    public static class StringToColorConverter
    {
        public static Colors Convert(string userColor)
        {
            switch (userColor.ToLower())
            {
                case "green":
                    return Colors.Green;
                case "red":
                    return Colors.Red;
                case "blue":
                    return Colors.Blue;
                case "yellow":
                    return Colors.Yellow;
                default:
                    return Colors.Unknown;
            }
        }
    }
}
