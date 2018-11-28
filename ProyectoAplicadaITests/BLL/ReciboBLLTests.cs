using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoAplicadaI.Entidades;
using System;


namespace ProyectoAplicadaI.BLL.Tests
{
    [TestClass()]
    public class EmpeñosBLLTests
    {
      
        [TestMethod()]
        public void GuardarTest()
        {
            Empeños empeños = new Empeños();
            bool paso;
            empeños.EmpeñoId = 0;
            empeños.ClienteId = 0;
            empeños.NombredeCliente = "Fulano Detal";
            empeños.Fecha = DateTime.Now;
            empeños.MontoTotal = 5000;
            paso = EmpeñosBLL.Guardar(empeños);
            Assert.AreEqual(paso,true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Empeños empeños = new Empeños();
            bool paso;
            empeños.EmpeñoId = 0;
            empeños.ClienteId = 0;
            empeños.NombredeCliente = "Fulano Detal";
            empeños.Fecha = DateTime.Now;
            empeños.MontoTotal = 10000;
            paso = EmpeñosBLL.Modificar(empeños);
            Assert.AreEqual(paso, true);

        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 0;
            Empeños empeños = new Empeños();
            empeños = EmpeñosBLL.Buscar(id);

            Assert.IsNotNull(empeños);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var listar = EmpeñosBLL.GetList(x => true);
            Assert.IsNotNull(listar);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            int id = 0;
            bool paso;
            paso = EmpeñosBLL.Eliminar(id);

            Assert.AreEqual(paso,true);
        }
    }
}