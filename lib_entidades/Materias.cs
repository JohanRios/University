using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Materias
    {
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }
        public int Creditos { get; set; }
        [NotMapped] public Niveles? _Nivel { get; set; } 


        //Crea nuevas materias 
        public void Crear() { 
        }

        //Elimina una materia que ya no se ve
        public void Eliminar() { 
        }
    }
}
