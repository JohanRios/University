using lib_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface ISalonesRepositorio
    {
        List<Salones> Listar();
        Salones Guardar(Salones entidad);
        Salones Modificar(Salones entidad);
        Salones Borrar(Salones entidad);
    }
}
