using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IGuessable
{
    public static void Low() { }

    public static void High() { }
}

namespace ParProgrammeringGuessingNumber
{

    internal class Brain : IGuessable
    {
        public static int MaxValue { get; set; } = 1001;
        public static int MinValue { get; set; } = 1;
        public static int Low(int number) 
        {
            MaxValue= number;
            Random random = new Random();
            number = random.Next(MinValue, MaxValue);
            Print.ComputersGuess(number);
            return number;
        }

        public static int High(int number) 
        {
            MinValue = number;
            Random random = new Random();
            number = random.Next(MinValue, MaxValue);
            Print.ComputersGuess(number);
            return number;
        }
    }

    internal class NoBrain : IGuessable
    {

        public static int Low(int number) 
        {
            Random random= new Random();
            number = random.Next(1, number);
            Print.ComputersGuess(number);
            return number;
        }

        public static int High(int number) 
        {
            Random random = new Random();
            number = random.Next(number, 1001);
            Print.ComputersGuess(number);
            return number;
        }
    }
}