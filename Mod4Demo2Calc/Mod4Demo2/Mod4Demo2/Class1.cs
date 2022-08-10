using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Demo2
{
    interface ICalculator
    {
        int Add(int i, int j);
        int Multiply(int i, int j);
        int Divide(int i, int j);
        int Subtraction(int i, int j);
    }
    //interface ICalculator2
    //{
    //    int Add(int i,int j);
    //}
    class MathCls : ICalculator //ICalculator2
    {
        // implicit implementation


        // explicit implementation
        int ICalculator.Add(int i, int j)
        {
            return i + j;
           
        }

        

        int ICalculator.Divide(int i, int j)
        {
            throw new NotImplementedException();
        }

        int ICalculator.Multiply(int i, int j)
        {
            return i * j;
           
        }

        int ICalculator.Subtraction(int i, int j)
        {
            throw new NotImplementedException();
        }
    }

}
