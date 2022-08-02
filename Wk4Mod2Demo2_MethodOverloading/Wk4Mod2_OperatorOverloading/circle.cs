using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Mod2_OperatorOverloading
{
    internal class circle
    {

        public double Radius { get; set; }
        public double area { get; set; }


        // This calculate area method isn't used as part of the operator overloading
        public void CalculateArea()
        {
            this.area = Math.PI * this.Radius * this.Radius;
        }

        // This is an example of operator overloading, we added a new functionality to the + operation

        // This 'circle' in the name is in reference to the return type from this method which will 
        // return an object of the circle class. The 'name' of this method is operator + 
        public static circle operator +(circle c1, circle c2)
        {
            circle cnew = new circle();
            cnew.Radius = c1.Radius + c2.Radius;
            return cnew;
        }

        public static circle operator -(circle c1, circle c2)
        {
            circle newCircle = new circle();
            newCircle.Radius = c1.Radius - c2.Radius;
            return newCircle;
        }
    }
}