using System.ComponentModel.DataAnnotations;
namespace ProyectoAplicadaI.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuariosId { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string TipodeUsuario { get; set; }
        public Usuarios()
        {
            UsuariosId = 0;
            Nombre = string.Empty;
            Usuario = string.Empty;
            Contraseña = string.Empty;
            TipodeUsuario = string.Empty;
        }
    }
}
