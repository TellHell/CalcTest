using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCalc.Managers
{
    //Результат выполнения операции

    public class OperationResult
    {
        public long Id { get; set; }

        public string OperationName { get; set; }

        public string Arguments { get; set; }

        public double? Result { get; set; }

        //Продолжительность выполнения операции
        public long ExecutionTime { get; set; }

        //Дата выполнения операции
        public DateTime ExecutionDate { get; set; }

    }
}