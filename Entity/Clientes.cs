using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [Serializable]
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public decimal Balance { get; set; }
        public Clientes()
        {
            ClienteId = 0;
            Nombres = string.Empty;
            Balance = 0;

        }

        public Clientes(int clienteId, string nombres, decimal balance)
        {
            ClienteId = clienteId;
            Nombres = nombres;
            Balance = balance;
        }
    }
}
