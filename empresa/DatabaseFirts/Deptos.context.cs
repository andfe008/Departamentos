using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace empresa.DatabaseFirts
{
    public class Deptos: DbContext
    {
        public Deptos()
            : base("Db")
        {
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    throw new UnintentionalCodeFirstException();
        //}

        public virtual DbSet<HR_DEPARTAMENTO> HR_DEPARTAMENTO { get; set; }
        public virtual DbSet<HR_PAGO> HR_PAGO { get; set; }
    }
}