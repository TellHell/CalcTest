using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary.DefaultOperations
{
     public class DivOperation : IOperation
    {
        public string Name
        {
            get { return "divide"; }
        }

        public double Calc(int x, int y)
        {
            return y == 0 ? Double.NaN : x * 1d / y;
        }
    }
}
