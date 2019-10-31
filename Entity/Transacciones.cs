using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [Serializable]
    public class Transacciones
    {
        [Key]
        public int TransaccionesId { get; set; }
        public int ClienteId { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public decimal Monto { get; set; }

        public Transacciones()
        {
            TransaccionesId = 0;
            ClienteId = 0;
            Cliente = string.Empty;
            Fecha = DateTime.Now;
            Tipo = string.Empty;
            Monto = 0;

        }
        public Transacciones(int transaccionesId,int clienteid,string cliente, DateTime fecha, string tipo, decimal monto)
        {
            TransaccionesId = transaccionesId;
            ClienteId = clienteid;
            Cliente = cliente;
            Fecha = fecha;
            Tipo = tipo;
            Monto = monto;
        }
    }
}
