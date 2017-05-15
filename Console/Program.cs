using CalcLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Output = System.Console;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Calc();

            string result = test.Execute(args[2], new object[]{ args[0], args[1]}).ToString();

            Output.WriteLine($"{args[0]} {args[2]} {args[1]} = {result}");

            Output.ReadKey();
            
            /*
            int x;
            int.TryParse(args[0], out x);

            int y;
            int.TryParse(args[1], out y);

            var operation = args[2];

            double result = 0;

            if (operation == "sum")
            {
                result = test.Sum(x, y);
            }

            else if (operation == "divide")
            {
                result = test.Divide(x, y);
            }
            */
        }
    }
}
