using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethodDemo
{

    internal class Program
    {
        // no mod 8
        // mod 7, 9 (intro to wpf) , 10 (multi tasking)
        // this delegate points to functions which take 1 int argument and returns bool
        public delegate bool Mydel(int num);
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
           
           
            // normal function call
            bool result = CheckNum(300);
            
            // delegate call:

            Mydel del = new Mydel(CheckNum);
            result = del(400);

            //anonymous method
            Mydel pointer = delegate (int num)
              {
                  return (num > 500);
              };
            pointer(700);

            //lambda expressions ( omit delegate, data type)
            // applications of lambda exp:
            // 

            Mydel pointer2 = (num) =>
              {
                  // new logic
                  if (num > 1000)
                      return true;
                  else return false;
              };

           







        }
        static bool CheckNum(int num)
        {
            if(num>100)
                return true;
            else
                return false;
        }
    }
}
