using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DAL;

namespace Entity.Tests
{
    [TestClass()]
    public class TransaccionesTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Transacciones> repositorio;
            repositorio = new RepositorioBase<Transacciones>(new Contexto());

            Assert.IsTrue(repositorio.Guardar(new Transacciones()));
        }
        [TestMethod()]

        public void GetList()
        {
            RepositorioBase<Transacciones> repositorio;
            repositorio = new RepositorioBase<Transacciones>(new Contexto());
            Assert.IsNotNull(repositorio.GetList(a => true));
        }
        [TestMethod()]

        public void Buscar()
        {
            RepositorioBase<Transacciones> repositorio;
            repositorio = new RepositorioBase<Transacciones>(new Contexto());
            Assert.IsNotNull(repositorio.Buscar(1));
        }
        [TestMethod()]

        public void Modificar()
        {
            RepositorioBase<Transacciones> repositorio;
            repositorio = new RepositorioBase<Transacciones>(new Contexto());
            Transacciones transacciones = new Transacciones();

            transacciones.TransaccionesId = 1;
            transacciones.Fecha = DateTime.Now;
            transacciones.Tipo = "Efectivo";
            transacciones.Monto = 100;
                   
        Assert.IsTrue(repositorio.Modificar(transacciones));
        }
        [TestMethod()]

        public void Eliminar()
        {
            RepositorioBase<Transacciones> repositorio;
            repositorio = new RepositorioBase<Transacciones>(new Contexto());
            Assert.IsNotNull(repositorio.Eliminar(1));
        }
    }
}