using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary.DefaultOperations
{
    public class SqrtOperation : IOperation
    {
        public string Name
        {
            get { return "sqrt"; }
        }

        public double Calc(int x, int y)
        {
            return Math.Round(Math.Sqrt(x), y);
        }
    }
}
