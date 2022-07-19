using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod9Demo2
{
    internal class LoginExceptions:Exception

    {

        // lambda expression : => goes to

        // We are overriding the message property from the base class (Exception is the base class). 
        // This is a virtual class, we know this because we did not get an error when we invoked it. 
        public override string Message => $"Invalid login attempt at {DateTime.Now} ";


    }
}
