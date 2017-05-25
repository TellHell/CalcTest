using DBModel.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBModel.Models
{
    //Результат выполнения операции
    public class OperationResult
    {
        public virtual int Id { get; set; }

        public virtual string OperationName { get; set; }

        public virtual string Arguments { get; set; }

        public virtual double? Result { get; set; }

        //Продолжительность выполнения операции
        public virtual long ExecutionTime { get; set; }

        //Дата выполнения операции
        public virtual DateTime ExecutionDate { get; set; }

        public virtual User Iniciator { get; set; }
    }
}