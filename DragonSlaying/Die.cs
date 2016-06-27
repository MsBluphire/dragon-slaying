using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlaying
{
    public class Die
    {
        Random random;
        Random r = new Random();
        r.Next(1,20);
        public int NumberOfSides { get; set; }

        /// <summary>
        /// Constructs a 6-sided Die.
        /// </summary>
        public Die() : this(6)
        {
        }

        /// <summary>
        /// Constructs a Die with the specified number of sides.
        /// </summary>
        /// <param name="numberOfSides">The number of sides on the Die</param>
        public Die(int numberOfSides)
        {
            NumberOfSides = numberOfSides;
        }        // TODO
        

        /// <summary>
        /// Rolls the die.
        /// </summary>
        /// <returns>A random number between 1 and <see cref="NumberOfSides"/></returns>
        public int Roll();
        {
           return r.Next(); // TODO
        
        }
    }
}
