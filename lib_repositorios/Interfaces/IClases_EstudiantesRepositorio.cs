using lib_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface IClases_EstudiantesRepositorio
    {
        List<Clases_Estudiantes> Listar();
        Clases_Estudiantes Guardar(Clases_Estudiantes entidad);
        Clases_Estudiantes Modificar(Clases_Estudiantes entidad);
        Clases_Estudiantes Borrar(Clases_Estudiantes entidad);
    }
}
