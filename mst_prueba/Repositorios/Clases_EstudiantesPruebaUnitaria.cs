using lib_repositorios;
using lib_repositorios.Interfaces;
using lib_repositorios.Implementaciones;


namespace mst_prueba.Repositorio
{
    [TestClass]
    public class Clases_EstudiantesPruebaUnitaria
    {
        private IClases_EstudiantesRepositorio? iRepositorio = null;

        public Clases_EstudiantesPruebaUnitaria()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=DESKTOP-A6721R1\\SQLEXPRESS;database=BD_Universidad;Integrated Security=True;TrustServerCertificate=true;";
            iRepositorio = new Clases_EstudiantesRepositorio(conexion);
        }

        [TestMethod]
        public void Ejecutar()
        {
            Listar();
        }

        private void Listar()
        {
            var lista = iRepositorio!.Listar();
            Assert.IsTrue(lista.Count > 0);
        }
    }
}