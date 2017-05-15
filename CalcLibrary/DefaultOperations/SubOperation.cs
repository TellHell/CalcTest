using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary.DefaultOperations
{
    public class SubOperation : IOperation
    {
        public string Name
        {
            get { return "sub"; }
        }

        public double Calc(int x, int y)
        {
            return x - y;
        }
    }
}
