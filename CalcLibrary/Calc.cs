using System;
using System.Collections.Generic;
using System.IO;
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
            Operations = new List<IOperation>();

            //var assm = Assembly.GetAssembly(typeof(IOperation));
            //var types = assm.GetTypes().ToList();
            var types = new List<Type>();

            //найти dll рядом с нашим exe
            var dlls = Directory.GetFiles(Directory.GetCurrentDirectory(),"*.dll");
            foreach (var dll in dlls)
            {
                //загрузить ее как сборку
                var assm = Assembly.LoadFrom(dll);
                //добавить типы
                types.AddRange(assm.GetTypes());
            }


            var ioper = typeof(IOperation);

            foreach (var type in types)
            {
                if (type.IsInterface)
                    continue;

                var interfaces = type.GetInterfaces();

                if (interfaces.Contains(ioper))
                {
                    var oper = Activator.CreateInstance(type) as IOperation;
                    if (oper != null)
                    {
                        Operations.Add(oper);
                    }
                }
            }
        }

        public IList<IOperation> Operations { get; private set; }

        // очевидно надо добавить параметр 
        public object ExecuteNew(string operation, object[] args)
        {
            //var assm = Assembly.GetAssembly(typeof(IOperation));
            //var types = assm.GetTypes().ToList();

            IOperation test = null;
            var operName = test as IOperationArgs;
            if (operName == null)
            {
                var oper = Operations.FirstOrDefault(it => it.Name == operation);

                if (oper == null)
                {
                    return "Error";
                }
                else
                {
                    double result = 0;

                    int x;
                    int.TryParse(args[0].ToString(), out x);

                    int y;
                    int.TryParse(args[1].ToString(), out y);
                    result = oper.Calc(x, y);
                    return result;
                }
                
            }
            else if(operName != null)
            {
                
                IOperationArgs oper = Operations.FirstOrDefault(it => it.Name == operation);

                if (oper == null)
                {
                    return "Error";
                }
                else
                {
                    double result = 0;
                    result = oper.Calc(args.Select(it => int.Parse(it.ToString())));
                    return result;
                }
            }
            return "Some Error";
            
        }


        [Obsolete]
        public object Execute(string operation, object[] args)
        {
            var oper = Operations.FirstOrDefault(it => it.Name == operation);

            //var assm = Assembly.GetAssembly(typeof(IOperation));
            //var type = oper.GetType();
            

            if (oper == null)
            {
                return "Error";
            }

            else
            {
                double result = 0;

                var operArgs = oper as IOperationArgs;

                if (operArgs != null)
                {
                    result = operArgs.Calc(args.Select(it=>int.Parse(it.ToString())));
                }
                else
                {

                    int x;
                    int.TryParse(args[0].ToString(), out x);

                    int y;
                    int.TryParse(args[1].ToString(), out y);
                    result = oper.Calc(x, y);
                }
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

        [Obsolete("Не используйте")]
        public double Divide(int x, int y)
        {
            //return y == 0 ? Double.NaN : x * 1d / y;
            var r = Execute("divide", new object[] { x, y });
            return double.Parse(r.ToString());
        }
    }
}
