using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoAplicadaI.Entidades;

namespace ProyectoAplicadaI.BLL.Tests
{
    [TestClass()]
    public class ClienteBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Clientes clientes = new Clientes
            {
                ClienteId = 0,
                Nombre = "juan perez",
                Cedula = "056-1234567-8",
                Direccion = "su casa",
                Telefono = "809-123-4567"
            };
            paso = ClienteBLL.Guardar(clientes);
            Assert.AreEqual(paso,true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Clientes clientes = new Clientes
            {
                ClienteId = 0,
                Nombre = "juan perez",
                Cedula = "056-1234567-8",
                Direccion = "su casa",
                Telefono = "809-123-4567"
            };
            paso = ClienteBLL.Modificar(clientes);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 0;
            Clientes clientes = new Clientes();
            clientes = ClienteBLL.Buscar(id);
            Assert.IsNotNull(clientes);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var listar = ClienteBLL.GetList(x => true);
            Assert.IsNotNull(listar);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            int id = 0;
            paso = ClienteBLL.Eliminar(id);
            Assert.AreEqual(paso, true);
        }
    }
}