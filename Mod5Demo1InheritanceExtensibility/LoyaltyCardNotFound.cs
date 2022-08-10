using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5Demo1InheritanceExtensibility
{
    [Obsolete] // system
    internal class LoyaltyCardNotFound : Exception
    {

        public override string Message => "Loyalty card not found";
    }

    class TestAttribute : Attribute 
    
    {
    
    
    }

}
