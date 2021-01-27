using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceForms
{
    // This is the aRandomVariable class
    public class aRandomVariable
    {
        // Declarations
        private Random rand;
        private int minV, maxV;

        // This constructor contains no parameters
        public aRandomVariable()
        { // Create a new random object and use it to create an int from 1-6.
            rand = new Random();
            minV = 1;
            maxV = 7;
        }

        // This constructor has 2 parameters (a minimum and maximum value).
        public aRandomVariable(int minValue, int maxValue)
        { // Create a new random object and use it to create an int from min to max.
            rand = new Random();
            minV = minValue;
            maxV = maxValue + 1;
        }

        // This implicit operator converts an aRandomVariable object to an int.
        public static implicit operator int(aRandomVariable var) => var.rand.Next(var.minV, var.maxV);
    }
}
