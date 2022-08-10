using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5Demo1InheritanceExtensibility
{
    public abstract class Beverage 
    {


        public virtual void SetTemperature()
        {

            //logic 
        }


        public abstract void CalculatePrice();

    }

    public class Coffee : Beverage
    {
        protected double flatDiscount = 0.1; // can be used from derrived classes as well

        private int temp; // use it anywhere in the same class only


        // use sealed to stop overriding the method in hierarchy. abstract & sealed are kind of the opposites
        // your hierarchy would start with abstract & end with sealed
        public sealed override void CalculatePrice() // abstract
        {
            // logic
            throw new NotImplementedException();
        }

        public override void SetTemperature()
        {
            // this has a call already because it's virtual and may already have some logic in it
            base.SetTemperature();  
        }


    public sealed class Espresso : Coffee
    {


            public new void CalculatePrice()// hiding base class methods 
            {

            }
            public override void SetTemperature()
            {
                base.SetTemperature();
                base.flatDiscount = flatDiscount;
            }
            
        }
}
}
