using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammeringGuessingNumber
{
    internal class Logic
    {
        public static int number { get; set; }
        public static int HolyNumber { get; set; }
        public static int WhatBrain { get; set; }

        public static void Run()
        {
            Spelaren spelaren = new Spelaren();
            Meny(HolyNumber);
        }

        public static void Meny(int HolyNumber)
        {
            Print.MenyVal();
            SwitchMeny(); //varje metod has soul purpose. mjau. SOUL. 
            Print.ChooseNumber();
            HolyNumber = Spelaren.PickANumber(HolyNumber);
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
                    WhatBrain = 1;
                    break;
                //metod för Brainz

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    WhatBrain = 2;
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
            if (WhatBrain == 1)
            {
                BrainCheck(HolyNumber);
            } 
            else if (WhatBrain == 2)
            {
                NoBrainCheck(HolyNumber);
            }
        }
        public static void BrainCheck(int HolyNumber)
        {
            while (true)
            {
                if (number == HolyNumber)
                {
                    Print.CorrectGuess();
                    Print.Win();
                    break;
                }
                else
                {
                    Print.GiveHints();
                    number = Spelaren.TooHighTooLowBrain(number);
                }
            }
        }
        public static void NoBrainCheck(int HolyNumber)
        {
            while (true)
            {
                if (number == HolyNumber)
                {
                    Print.CorrectGuess();
                    Print.Win();
                    break;
                }
                else
                {
                    Print.GiveHints();
                    number = Spelaren.TooHighTooLowNoBrain(number);
                }
            }
        }
    }

}

