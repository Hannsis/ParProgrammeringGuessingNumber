using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IGuessable
{
    void Guess(); //interface metod för att gissa siffra (does not have a body) 
}

namespace ParProgrammeringGuessingNumber
{
    internal class Computer : IGuessable
    {
        public void Guess() 
        {
        
        }
    }
}
