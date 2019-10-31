using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Repositorio
    {
        /*
         class RepositorioServicio : RepositorioBase<Servicios>
    {
        
            public RepositorioServicio(Contexto contexto) : base(contexto)
            {

            }
            public override bool Guardar(Servicios servicios)
            {
                RepositorioServicio repositorio = new RepositorioServicio(new Contexto());
                bool paso = false;
                try
                {
                    if (_contexto.Servicios.Add(servicios) != null)
                        foreach (var item in servicios.Detalle)
                        {
                            _contexto.Estudiantes.Find(item.EstudianteId).Balance += item.Importe;
                           /* var cantidad = _contexto.Categorias.Find(item.CategoriaId).Cantidad += 1;
                            var promedio = _contexto.Categorias.Find(item.CategoriaId).PromedioNeto += item.Promedio;
                            var promedioTota = promedio / cantidad;
                            _contexto.Categorias.Find(item.CategoriaId).PromedioTotal = promedioTota;*//*
    }


    paso = _contexto.SaveChanges() > 0;
                    _contexto.Dispose();
                }
                catch (Exception)
                {

                    throw;
                }

                return paso;
            }

            public override Servicios Buscar(int id)
{
    Servicios servicios = new Servicios();
    try
    {
        servicios = _contexto.Servicios.Find(id);
        if (servicios != null)
        {
            servicios.Detalle.Count();
        }

    }
    catch (Exception)
    {

        throw;
    }
    return servicios;
}
public override bool Modificar(Servicios servicios)
{
    RepositorioServicio repositorio = new RepositorioServicio(new Contexto());

    var Anterior = Buscar(servicios.ServicioId);
    bool paso = false;
    Contexto con = new Contexto();
    try
    {
        Contexto contexto = new Contexto();
        bool pas = false;
        foreach (var item in Anterior.Detalle.ToList())
        {
            if (!servicios.Detalle.Exists(d => d.id == item.id))
            {
                contexto.Estudiantes.Find(item.EstudianteId).Balance += item.Importe;
                contexto.Entry(item).State = EntityState.Deleted;
                pas = true;
            }
        }
        if (pas)
            contexto.SaveChanges();
        contexto.Dispose();


        foreach (var item in servicios.Detalle)
        {
            var estado = EntityState.Unchanged;
            if (item.id == 0)
            {
                estado = EntityState.Added;
            }
            con.Entry(item).State = estado;
            con.Estudiantes.Find(item.EstudianteId).Balance -= item.Importe;

        }


        con.Entry(servicios).State = EntityState.Modified;
        if (con.SaveChanges() > 0)
            paso = true;
    }
    catch (Exception)
    {
        throw;
    }
    return paso;

}

public override bool Eliminar(int id)
{
    bool paso = false;
    RepositorioServicio repositorio = new RepositorioServicio(new Contexto());
    Servicios evaluaciones = _contexto.Servicios.Find(id);
    foreach (var item in evaluaciones.Detalle)
    {
        _contexto.Estudiantes.Find(item.EstudianteId).Balance -= item.Importe;
    }
    _contexto.Servicios.Remove(evaluaciones);

    paso = _contexto.SaveChanges() > 0;

    return paso;
}



        }*/
    }
}
