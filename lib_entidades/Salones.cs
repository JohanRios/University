using System.ComponentModel.DataAnnotations;

namespace lib_entidades
{
    public class Salones
    {
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }

        //Actualizar la capacidad del salon
        public void Actualizar() { 
        }

        //Crear nuevos salones
        public void Crear() { 
        }

    }
}