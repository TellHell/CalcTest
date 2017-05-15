using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{
    public class Calc
    {
        public Calc()
        {
            operations = new List<IOperation>();

            var assm = Assembly.GetAssembly(typeof(IOperation));

            var types = assm.GetTypes();

            foreach (var type in types)
            {
                var interfaces = type.GetInterfaces();

                if (interfaces.Contains(typeof(IOperation)))
                {
                    var oper = Activator.CreateInstance(type) as IOperation;
                    if (oper != null)
                    {
                        operations.Add(oper);
                    }
                }
            }
        }

        private IList<IOperation> operations { get; set; }

        public object Execute(string operation, object[] args)
        {
            var oper = operations.FirstOrDefault(it => it.Name == operation);

            if (oper == null)
            {
                return "Error";
            }

            else
            {
                int x;
                int.TryParse(args[0].ToString(), out x);

                int y;
                int.TryParse(args[1].ToString(), out y);

                var result = oper.Calc(x, y);

                return result;
            }
        }

        [Obsolete("Не используйте")]
        public int Sum (int x, int y)
        {
            //return x + y;
            var r = Execute("sum", new object[] { x, y });
            return int.Parse(r.ToString());
        }

        public double Divide(int x, int y)
        {
            //return y == 0 ? Double.NaN : x * 1d / y;
            var r = Execute("divide", new object[] { x, y });
            return double.Parse(r.ToString());
        }
    }
}
