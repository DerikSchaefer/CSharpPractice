using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExentensionMethods
{


    // We want to add an extension method to the string class that searches a string for a number
    
    // The class has to be static for us to do an extension method, it must be public / static
    
    public static class ExtensionMethods 
    {

        // step 2: method must be public static
        public static bool ContainsNumbers(this string s) // extending string functionality
        {

            return Regex.IsMatch(s, @"\d");



        } 

    }
}
