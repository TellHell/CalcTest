using CalcLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCalc.Models
{
    public class OperationViewModel
    {

        //public IOperation Operation { get; set; }
       // public List<IOperation> ListOperations { get; set; }

        public string Operation { get; set; }

        public string InputData { get; set; }

        public string Result { get; set; }
    }
}