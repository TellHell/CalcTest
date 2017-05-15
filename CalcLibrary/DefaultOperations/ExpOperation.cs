using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary.DefaultOperations
{
    public class ExpOperation : IOperation
    {
        public string Name
        {
            get { return "exp"; }
        }

        public double Calc(int x, int y)
        {
            return Math.Pow(x,y);
        }
    }
}
