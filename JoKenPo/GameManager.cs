using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoKenPo
{
    internal static class GameManager
    {
        private static Options pcChoice;

        // Images to be displayed in the form
        public static Image PlayerChoiceImg { get; private set; }
        public static Image PcChoiceImg { get; private set; }
        public static Image ResultImg { get; private set; }

        public static event EventHandler OnPlayerPlay;

        public enum Result
        {
            Win,
            Lose,
            Draw
        }

        public enum Options
        {
            Rock,
            Paper,
            Scissors
        }

        private static Image[] optionsImagesArray =
        {
            Image.FromFile("Images/Pedra.png"),
            Image.FromFile("Images/Papel.png"),
            Image.FromFile("Images/Tesoura.png")
        };

        private static Image[] resultImagesArray =
        {
            Image.FromFile("Images/Ganhar.png"),
            Image.FromFile("Images/Perder.png"),
            Image.FromFile("Images/Empatar.png")
        };

        private static void RandomizePcChoice()
        {
            Random random = new Random();
            pcChoice = (Options)random.Next(0, 3);

            PcChoiceImg = optionsImagesArray[(int)pcChoice];
        }

        public static Result Play(Options playerChoice)
        {
            Result result;

            RandomizePcChoice();

            if (playerChoice == pcChoice)
            {
                result = Result.Draw;
            }

            else if ((playerChoice == Options.Rock && pcChoice == Options.Scissors) || 
                (playerChoice == Options.Paper && pcChoice == Options.Rock) || 
                (playerChoice == Options.Scissors && pcChoice == Options.Paper))
            {
                result = Result.Win;
            }
            else
            {
                result = Result.Lose;
            }

            PlayerChoiceImg = optionsImagesArray[(int)playerChoice];
            ResultImg = resultImagesArray[(int)result];

            OnPlayerPlay?.Invoke(null, EventArgs.Empty);

            return result;
        }
    }
}
