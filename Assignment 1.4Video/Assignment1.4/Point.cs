using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4
{

    //1.Create a structure named “Point” and 2 data members: X and Y coordinate. 
    struct Point
    {

        //Declare two private variables int X and Int y

        private int x;
        private int y;

        //Create a public constructor set the parameters and int x and int y

        public Point(int x, int y)
        {

            //Use the this keyword to gain access to the private member variables we created

            this.x = x;
            this.y = y;

        }

        //Create our get and set methods

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        //Return for get

        //Value for set

        //Do this twice once for int Y and once for int Y

    }
}