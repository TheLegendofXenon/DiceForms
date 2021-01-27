using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceForms
{
    public class aDie : aRandomVariable
    {
        // Declarations
        private Random rand;
        private int minV, maxV;

        // This constructor contains no parameters
        public aDie()
        { // Create a new random die with 6 faces.
            rand = new Random();
            minV = 1;
            maxV = 7;
        }

        // This constructor contains a seed parameter
        public aDie(int seed)
        { // Create a new random die with 6 faces.
            rand = new Random(seed);
            minV = 1;
            maxV = 7;
        }

        // This function returns the int in the random next function.
        public int Next => rand.Next(minV, maxV);

        // This implicit operator converts an aDie object to an int.
        public static implicit operator int(aDie die) => die.rand.Next(die.minV, die.minV);
    }
}
