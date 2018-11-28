using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoAplicadaI.Entidades;
using System;

namespace ProyectoAplicadaI.BLL.Tests
{
    [TestClass()]
    public class CobroBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Cobros cobro = new Cobros();
            bool paso;
            cobro.CobroId = 0;
            cobro.EmpeñoId = 0;
            cobro.Fecha = DateTime.Now;
            cobro.Abono = 100;
            paso = CobrosBLL.Guardar(cobro);
            Assert.AreEqual(paso, true);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            Cobros cobro = new Cobros();
            bool paso;
            cobro.CobroId = 0;
            cobro.EmpeñoId = 0;
            cobro.Fecha = DateTime.Now;
            cobro.Abono = 50;
            paso = CobrosBLL.Modificar(cobro);
            Assert.AreEqual(paso, true);
        }
        [TestMethod()]
        public void BuscarTest()
        {
            int id = 0;
            Cobros cobros = new Cobros();
            cobros= CobrosBLL.Buscar(id);
            Assert.IsNotNull(cobros);
        }
        [TestMethod()]
        public void GetListTest()
        {
            var lista = CobrosBLL.GetList(x => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            int id = 0;
            bool paso;
            paso = CobrosBLL.Eliminar(id);
            Assert.AreEqual(paso,true);
        }
    }
}