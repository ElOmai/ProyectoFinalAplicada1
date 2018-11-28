using ProyectoAplicadaI.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace ProyectoAplicadaI.BLL
{
    public class UsuariosBLL
    {
        public static bool Guardar(Usuarios usuario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Usuarios.Add(usuario) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return paso;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Usuarios usuarios = contexto.Usuarios.Find(id);
                if (usuarios != null)
                {
                    contexto.Entry(usuarios).State = EntityState.Deleted;
                }
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                    contexto.Dispose();
                }
            }
            catch (Exception) { throw; }
            return paso;
        }

        public static bool Modificar(Usuarios usuarios)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(usuarios).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return paso;
        }
        public static Usuarios Buscar(int id)
        {
            Usuarios usuarios = new Usuarios();
            Contexto contexto = new Contexto();
            try
            {
                usuarios = contexto.Usuarios.Find(id);
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return usuarios;
        }
        public static List<Usuarios> GetList(Expression<Func<Usuarios, bool>> expression)
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            Contexto contexto = new Contexto();
            try
            {
                usuarios = contexto.Usuarios.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception) { throw; }
            return usuarios;
        }
        private static Usuarios user = new Usuarios();

        public static void NombreLogin(string nombre, string tipodeusuario)
        {
            user.Nombre = nombre;
            user.TipodeUsuario = tipodeusuario;
        }
        public static Usuarios ReturnUsuario()
        {
            return user;
        }
    }
}
