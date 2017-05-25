using DBModel.Models;
using System;
using System.Data.Entity;

namespace DBModel.Helpers
{

    [Obsolete("Устарел", false)]
    public class CalcContext : DbContext
    {
        public CalcContext() : base("EFConnection")
        {

        }

        public DbSet<OperationResult> OperationRtsults { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
