using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammeringGuessingNumber
{
    internal class Spelaren
    {
        public static int HolyNumber { get; set; }

        public static int PickANumber()
        {
            int guess;
            int.TryParse(Console.ReadLine(), out guess);
            HolyNumber = guess;
            return HolyNumber;
        }
    }

}
