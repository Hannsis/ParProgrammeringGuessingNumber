using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammeringGuessingNumber
{
    internal class Spelaren
    {

        public static int PickANumber(int HolyNumber)
        {
            int guess;
            int.TryParse(Console.ReadLine(), out guess);
            HolyNumber = guess;
            return HolyNumber;
        }

        public static int TooHighTooLowBrain(int number) 
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    number = Brain.Low(number);
                    return number;
                    //metod för lägre
                    break;
                case ConsoleKey.D2:
                    number = Brain.High(number);
                    //metod för högre
                    return number;
                    break;
                default:
                    Console.WriteLine("bob");
                    return number;
                    break;
            }
        }

        public static int TooHighTooLowNoBrain(int number)
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    number = NoBrain.Low(number);
                    return number;
                    //metod för lägre
                    break;
                case ConsoleKey.D2:
                    number = NoBrain.High(number);
                    //metod för högre
                    return number;
                    break;
                default:
                    Console.WriteLine("bob");
                    return number;
                    break;
            }
        }


    }


}
