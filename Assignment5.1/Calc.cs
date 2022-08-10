using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5._1
{
    interface ICalculator
    {
        int Add(int i, int j);

        int Multiply(int i, int j);

        int Substract(int i, int j);

        int Divide(int i, int j);
    }
    class MathCls : ICalculator
    {
        public int Add(int i, int j)
        {
            throw new NotImplementedException();
        }

        public int Divide(int i, int j)
        {
            throw new NotImplementedException();
        }

        public int Multiply(int i, int j)
        {
            throw new NotImplementedException();
        }

        public int Substract(int i, int j)
        {
            throw new NotImplementedException();
        }
    }
}