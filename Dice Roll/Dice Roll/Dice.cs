using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Roll
{
    class Dice
    {
        // Field to represent the amount of sides the die will have
        private int dieSides, dieSideL, dieSideR;

        static Random rand = new Random();

        // Constructor
        public Dice()
        {
            dieSides = 6;
            dieSideL = 3;
            dieSideR = 2;
        }

        // Roll Left die method
        public void RollL()
        {

            // Random number determines the side of the die facing up
            if (rand.Next(1, dieSides) == 1)
            {
                dieSideL = 1;
            }
            else if (rand.Next(1, dieSides) == 2)
            {
                dieSideL = 2;
            }
            else if (rand.Next(1, dieSides) == 3)
            {
                dieSideL = 3;
            }
            else if (rand.Next(1, dieSides) == 4)
            {
                dieSideL = 4;
            }
            else if (rand.Next(1, dieSides) == 5)
            {
                dieSideL = 5;
            }
            else if (rand.Next(1, dieSides) == 6)
            {
                dieSideL = 6;
            }
            else if (rand.Next(1, dieSides) == 7)
            {
                dieSideL = 7;
            }
            else if (rand.Next(1, dieSides) == 8)
            {
                dieSideL = 8;
            }
            else if (rand.Next(1, dieSides) == 9)
            {
                dieSideL = 9;
            }
            else if (rand.Next(1, dieSides) == 10)
            {
                dieSideL = 10;
            }
            else if (rand.Next(1, dieSides) == 11)
            {
                dieSideL = 11;
            }
            else if (rand.Next(1, dieSides) == 12)
            {
                dieSideL = 12;
            }
            else if (rand.Next(1, dieSides) == 13)
            {
                dieSideL = 13;
            }
            else if (rand.Next(1, dieSides) == 14)
            {
                dieSideL = 14;
            }
            else if (rand.Next(1, dieSides) == 15)
            {
                dieSideL = 15;
            }
            else if (rand.Next(1, dieSides) == 16)
            {
                dieSideL = 16;
            }
            else if (rand.Next(1, dieSides) == 17)
            {
                dieSideL = 17;
            }
            else if (rand.Next(1, dieSides) == 18)
            {
                dieSideL = 18;
            }
            else if (rand.Next(1, dieSides) == 19)
            {
                dieSideL = 19;
            }
            else if (rand.Next(1, dieSides) == 20)
            {
                dieSideL = 20;
            }
        }

        // Roll Right die method
        public void RollR()
        {

            // Random number determines the side of the die facing up
            if (rand.Next(1, dieSides) == 1)
            {
                dieSideR = 1;
            }
            else if (rand.Next(1, dieSides) == 2)
            {
                dieSideR = 2;
            }
            else if (rand.Next(1, dieSides) == 3)
            {
                dieSideR = 3;
            }
            else if (rand.Next(1, dieSides) == 4)
            {
                dieSideR = 4;
            }
            else if (rand.Next(1, dieSides) == 5)
            {
                dieSideR = 5;
            }
            else if (rand.Next(1, dieSides) == 6)
            {
                dieSideR = 6;
            }
            else if (rand.Next(1, dieSides) == 7)
            {
                dieSideR = 7;
            }
            else if (rand.Next(1, dieSides) == 8)
            {
                dieSideR = 8;
            }
            else if (rand.Next(1, dieSides) == 9)
            {
                dieSideR = 9;
            }
            else if (rand.Next(1, dieSides) == 10)
            {
                dieSideR = 10;
            }
            else if (rand.Next(1, dieSides) == 11)
            {
                dieSideR = 11;
            }
            else if (rand.Next(1, dieSides) == 12)
            {
                dieSideR = 12;
            }
            else if (rand.Next(1, dieSides) == 13)
            {
                dieSideR = 13;
            }
            else if (rand.Next(1, dieSides) == 14)
            {
                dieSideR = 14;
            }
            else if (rand.Next(1, dieSides) == 15)
            {
                dieSideR = 15;
            }
            else if (rand.Next(1, dieSides) == 16)
            {
                dieSideR = 16;
            }
            else if (rand.Next(1, dieSides) == 17)
            {
                dieSideR = 17;
            }
            else if (rand.Next(1, dieSides) == 18)
            {
                dieSideR = 18;
            }
            else if (rand.Next(1, dieSides) == 19)
            {
                dieSideR = 19;
            }
            else if (rand.Next(1, dieSides) == 20)
            {
                dieSideR = 20;
            }
        }
        // Get and set dieSides value
        public int DieSides
        {
            get 
            {
                return dieSides;
            }

            set 
            {
                dieSides = value;
            }
        }

        // Get and Set dieSidesL
        public int DieSideL
        {
            get
            {
                return dieSideL;
            }

            set
            {
                dieSideL = value;
            }
        }
        // Get and Set dieSidesR
        public int DieSideR
        {
            get
            {
                return dieSideR;
            }

            set
            {
                dieSideR = value;
            }
        }

    }
}
