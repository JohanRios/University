using lib_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface IMateriasRepositorio
    {
        List<Materias> Listar();
        Materias Guardar(Materias entidad);
        Materias Modificar(Materias entidad);
        Materias Borrar(Materias entidad);
    }
}
