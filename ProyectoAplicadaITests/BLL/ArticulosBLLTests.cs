using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoAplicadaI.Entidades;

namespace ProyectoAplicadaI.BLL.Tests
{
    [TestClass()]
    public class ArticulosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Articulos articulos = new Articulos
            {
                ArticuloId = 0,
                Nombre = "Plancha",
                Inventario = 0
            };
            paso = ArticulosBLL.Guardar(articulos);
            Assert.AreEqual(paso,true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Articulos articulos = new Articulos
            {
                ArticuloId = 0,
                Nombre = "tanque",
                Inventario = 0
            };
            paso = ArticulosBLL.Guardar(articulos);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 1;
            Articulos articulos = new Articulos();
            articulos = ArticulosBLL.Buscar(id);
            Assert.IsNotNull(articulos);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var LISTAR = ArticulosBLL.GetList(X=>true );
            Assert.IsNotNull(LISTAR);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            int id = 4;
            paso = ArticulosBLL.Eliminar(id); 
            Assert.AreEqual(paso, true);
        }
    }
}