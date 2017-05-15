using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{
    public class Calc
    {
        public int Sum (int x, int y)
        {
            return x + y;
            //var r = (int)Execute("sum", new object[] { x, y });
            //return r;
        }

        public double Divide(int x, int y)
        {
            return y == 0 ? Double.NaN : x * 1d / y;
            //return (int)Execute("divide", new object[] { x, y });
        }
    }
}
