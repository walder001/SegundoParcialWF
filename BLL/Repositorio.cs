using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Repositorio : RepositorioBase<Transacciones>
    {
        public Repositorio(Contexto contexto) : base(contexto)
        {

        }
        public override bool Guardar(Transacciones transacciones)
        {
            Repositorio repositorio = new Repositorio(new Contexto());
            bool paso = false;
            try
            {
                if (_contexto.Transacciones.Add(transacciones) != null)
                     _contexto.Clientes.Find(transacciones.ClienteId).Balance += transacciones.Monto;
                
                paso = _contexto.SaveChanges() > 0;
                _contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }

            return paso;
        }

    }
}
