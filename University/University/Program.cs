using System;

namespace ConsoleApp.University
{
    public class Estados
    {
        private int id = 0;
        private string nombre = "";

        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
    }

    public class Niveles
    {
        private int id = 0;
        private string nombre = "";
        private int numero = 0;


        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public int Numero { get => this.numero; set => this.numero = value; }
    }

    public class Salones
    {
        private int id = 0;
        private string nombre = "";
        private int capacidad = 0;


        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public int Capacidad { get => this.capacidad; set => this.capacidad = value; }
    }
    public class Materias
    {
        private int id = 0;
        private string nombre = "";
        private int creditos = 0;
        private Niveles? nivel = null;


        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public int Creditos { get => this.creditos; set => this.creditos = value; }
        public Niveles? Nivel { get => this.nivel; set => this.nivel = value; }
    }


    public class Estudiantes
    {
        private int id = 0;
        private string cedula = "";
        private string nombre = "";
        private string carnet = "";
        private Niveles? nivel = null;


        public int Id { get => this.id; set => this.id = value; }
        public string Cedula { get => this.cedula; set => this.cedula = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Carnet { get => this.carnet; set => this.carnet = value; }
        public Niveles? Nivel { get => this.nivel; set => this.nivel = value; }
    }

    public class Clase_estudiantes
    {
        private int id = 0;
        private Estudiantes? estudiante = null;
        private Salones? salon = null;
        private Materias? materia = null;
        private double nota1 = 0;
        private double nota2 = 0;
        private double nota3 = 0;
        private double nota4 = 0;
        private double nota5 = 0;


        public int Id { get => this.id; set => this.id = value; }
        public Estudiantes? Estudiante { get => this.estudiante; set => this.estudiante = value; }
        public Salones? Salon { get => this.salon; set => this.salon = value; }
        public Materias? Materias { get => this.materia; set => this.materia = value; }
        public double Nota1 { get => this.nota1; set => this.nota1 = value; }
        public double Nota2 { get => this.nota2; set => this.nota2 = value; }
        public double Nota3 { get => this.nota3; set => this.nota3 = value; }
        public double Nota4 { get => this.nota4; set => this.nota4 = value; }
        public double Nota5 { get => this.nota5; set => this.nota5 = value; }
    }



}