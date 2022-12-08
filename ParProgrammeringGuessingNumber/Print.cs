using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammeringGuessingNumber
{
    internal static class Print
    {
        public static void MenyVal()
        {
            Console.WriteLine("Välkommen till gissningenleken som antingen krashar ditt liv eller inte.");
            Console.WriteLine("Tänk på ett tal mellan 1 och 1000, datorn ska gissa vilket tal du tänker på");
            Console.WriteLine("Välj mellan två olika personligheter! Antingen så tänker datorn logiskt, eller så tänker den inte alls... ");

            Console.WriteLine("\nTryck 1 för brains. Tryck 2 för inte brainz.");
            Console.WriteLine("Lycka till! ");
        }

        public static void ChooseNumber()
        {
            Console.WriteLine("\n\nSkriv in din siffra som jag ska gissa mellan 1 och 1000: ");
        }

        public static void ComputersGuess(int number)
        {
            Console.WriteLine($"Jag vill gissa nummer: {number}! \nSNELA säg att det är RÄÄÄTTT!! <3");
        }

        public static void GiveHints() 
        {
            Console.WriteLine("Fan det var fel....... ");
            Console.WriteLine("Kan du säga om jag ska gissa lägre eller högre? \nTryck 1 för lägre och 2 för högre! "); 
        }

        public static void CorrectGuess() 
        {
            Console.WriteLine("You tried to trick meeee, i guessed right all along! Bitch.");
        }
        public static void Win() 
        {
            Console.WriteLine("You won!");
        }
    }

}
