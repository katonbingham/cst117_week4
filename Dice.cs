using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4Exercise6
{
    class Dice
    {
        private int face;
        private int sides = 4;

        public Dice()
        {
            face = 0;
        }
        
        public void roll()
        {
            // create Random object
            Random rand = new Random();

            // use Random to determine what
            // dice face is shown
            face = rand.Next(1, 6);
        }

        public void roll(int x)
        {
            setSides(x);

            // create Random object
            Random rand = new Random();
            face = rand.Next(1, getSides());
        }
        
        public int getFace()
        {
            return face;
        }

        public int getSides()
        {
            return sides;
        }

        public void setSides(int x)
        {
            sides = x;
        }

        public void setFace(int x)
        {
            face = x;
        }
    }
}
