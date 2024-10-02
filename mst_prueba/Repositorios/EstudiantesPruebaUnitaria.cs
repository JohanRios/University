using lib_entidades;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace mst_prueba.Repositorio
{
    [TestClass]
    public class EstudiantesPruebaUnitaria
    {
        private IEstudiantesRepositorio? iRepositorio = null;

        public EstudiantesPruebaUnitaria()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=DESKTOP-A6721R1\\SQLEXPRESS;database=BD_Universidad;Integrated Security=True;TrustServerCertificate=true;";
            iRepositorio = new EstudiantesRepositorio(conexion);
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
