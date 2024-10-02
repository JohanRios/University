using lib_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface INivelesRepositorio
    {
        List<Niveles> Listar();
        Niveles Guardar(Niveles entidad);
        Niveles Modificar(Niveles entidad);
        Niveles Borrar(Niveles entidad);
    }
}
