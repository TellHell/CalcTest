using CalcLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using WebCalc.Managers;
using WebCalc.Models;

namespace WebCalc.Controllers
{
    public class CalcController : Controller
    {

        #region
        private Calc Calc { get; set; }

        private IEnumerable<SelectListItem> OperationList { get; set; }

        private IOperationResultRepository OperationResultRepository { get; set; }
        #endregion

        public CalcController()
        {
            Calc = new Calc(@"C:\Near\Docs\CalcTest\CalcTest\WebCalc\bin");

            OperationList = Calc.Operations.Select(o => new SelectListItem() { Text = $"{o.GetType().Name}.{o.Name}", Value = $"{o.GetType().Name}.{o.Name}" });

            OperationResultRepository = new OperationManager();
        }

        // GET: Calc
        public ActionResult Index()
        {
            var model = new OperationViewModel(OperationList);

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(OperationViewModel model)
        {
            var operResults = OperationResultRepository.GetAll();

            var oldResult = operResults.FirstOrDefault(
                op => op.OperationName == model.Operation && op.Arguments == model.InputData.Trim()
            );

            if (oldResult != null)
            {
                model.Result = $"Это уже вычисляли {oldResult.ExecutionDate}(заняло {oldResult.ExecutionTime} ms.) и получили {oldResult.Result}";
            }
            else
            {
                var stopWatch = new Stopwatch();
                stopWatch.Start();

                var names = model.Operation.Split('.');
                var opers = Calc.Operations.Where(o => o.Name == names[1]);
                var oper = opers.FirstOrDefault(o => o.GetType().Name == names[0]);
                var result = Calc.Execute(oper, model.InputData.Trim().Split(' '));
                Thread.Sleep(new Random().Next(1, 100));
                stopWatch.Stop();

                model.Result = $"{result}";

                var operResult = new OperationResult()
                {
                    OperationName = model.Operation,
                    Result = result as double?,
                    Arguments = model.InputData.Trim(),
                    ExecutionTime = stopWatch.ElapsedMilliseconds * 10,
                    ExecutionDate = DateTime.Now
                };

                OperationResultRepository.Save(operResult);
            }

            model.Operations = OperationList;

            return View(model);
        }

        public ActionResult DisplayListOfOperatons()
        {
            var operResults = OperationResultRepository.GetAll();

            return View(operResults);
        }
    }
}