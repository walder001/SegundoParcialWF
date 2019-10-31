using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Transacciones> Transacciones { get; set; }

        public Contexto() : base("SegundoParcialDB")
        {

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

    }
}
