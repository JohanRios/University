using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Clases_Estudiantes
    {
        [Key] public int Id { get; set; }
        [NotMapped] public Estudiantes? _Estudiante { get; set; }
        [NotMapped] public Salones? _Salon { get; set; }
        [NotMapped] public Materias? _Materia { get; set; }
        public Decimal Nota1 { get; set; }
        public Decimal Nota2 { get; set; }
        public Decimal Nota3 { get; set; }
        public Decimal Nota4 { get; set; }
        public Decimal Nota5 { get; set; }
        public Decimal NotaFinal { get; set; }


        //Calcula la nota final sacando un promedio
        public double CalcularNotaFinal(double Nota1, double Nota2, double Nota3, double Nota4, double Nota5, double NotaFinal) {
            //Lógica de la nota final
            return NotaFinal;
        }

        // Actualiza las notas del estudiante
        public void Actualizar() { 
        }

    }
}