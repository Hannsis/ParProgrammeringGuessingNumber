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
    }
}
