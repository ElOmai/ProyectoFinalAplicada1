using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoAplicadaI.Entidades;

namespace ProyectoAplicadaI.BLL.Tests
{
    [TestClass()]
    public class UsuariosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Usuarios usuarios = new Usuarios();
            bool paso;
            usuarios.UsuariosId = 1;
            usuarios.Nombre = "Luis Pérez";
            usuarios.Usuario = "elomai";
            usuarios.Contraseña = "luiomaipr1998";
            usuarios.TipodeUsuario = "Administrador";
            paso = UsuariosBLL.Guardar(usuarios);
            Assert.AreEqual(paso,true);
        }
      
        [TestMethod()]
        public void ModificarTest()
        {
            Usuarios usuarios = new Usuarios();
            bool paso;
            usuarios.UsuariosId = 1;
            usuarios.Nombre = "Luis Pérez";
            usuarios.Usuario = "omai";
            usuarios.Contraseña = "luiomaipr1998";
            usuarios.TipodeUsuario = "Administrador";
            paso = UsuariosBLL.Guardar(usuarios);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 1;
            Usuarios usuarios = new Usuarios();
            usuarios = UsuariosBLL.Buscar(id);
            Assert.IsNotNull(usuarios);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var listar = UsuariosBLL.GetList(x => true);
            Assert.IsNotNull(listar);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            int id = 1;
            paso = UsuariosBLL.Eliminar(id);
            Assert.AreEqual(paso,true);
        }
    }
}