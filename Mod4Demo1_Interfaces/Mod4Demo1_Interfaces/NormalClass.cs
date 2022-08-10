using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Demo1_Interfaces
{
    internal class NormalClass
    {

        // fields, properties, methods, evenets

        // create an instance
    }


    // We can not create an instance of an abstract class, they are meant to act as a base class
    abstract class AbstractClass
    {
        // normal methods, abstract methods (only declarations)
        public void NormalMethod()
        {
            // method body (logic)
        }

        public abstract void AbstractMethod();

        public virtual void VirtualMethod()
        {

        }

        public class DerrivedClass : AbstractClass
        {

            public override void VirtualMethod()
            {
                base.VirtualMethod();
            }
            public override void AbstractMethod()
            {
                throw new NotImplementedException();
            }
        }
    }
}
