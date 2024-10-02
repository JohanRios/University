using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_prueba.Repositorio
{
    [TestClass]
    public class EstadosPruebaUnitaria
    {
        private IEstadosRepositorio? iRepositorio = null;

        public EstadosPruebaUnitaria()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=DESKTOP-A6721R1\\SQLEXPRESS;database=BD_Universidad;Integrated Security=True;TrustServerCertificate=true;";
            iRepositorio = new EstadosRepositorio(conexion);
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