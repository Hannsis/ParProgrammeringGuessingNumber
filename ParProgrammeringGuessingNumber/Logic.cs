using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammeringGuessingNumber
{
    internal class Logic
    {
        public static int number;
            

        public static void Run(int HolyNumber)
        {
            Spelaren spelaren = new Spelaren();
            Meny(HolyNumber);
        }

        public static void Meny(int HolyNumber)
        {
            Print.MenyVal();
            SwitchMeny(); //varje metod has soul purpose. mjau. SOUL. 
            Print.ChooseNumber();
            Spelaren.HolyNumber = Spelaren.PickANumber();
            number = RandomizedGuess();
            Print.ComputersGuess(number);
            CheckNumber(HolyNumber);

        }

        public static void SwitchMeny()
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    break;
                //metod för Brainz

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    break;
                //metod för noBrainz

                default:
                    break;
            }
        }

        public static int RandomizedGuess()
        {
            Random random = new Random();
            number = random.Next(1, 1001);

            return number;
        }

        public static void CheckNumber(int HolyNumber)
        {
            if (number == HolyNumber)
            {
                Print.CorrectGuess();
            }
            else
            {
                Print.GiveHints();
                Spelaren.TooHighTooLow(number);
            }
        }


    }

}

