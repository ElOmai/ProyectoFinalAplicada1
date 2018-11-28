﻿using System.ComponentModel.DataAnnotations;
namespace ProyectoAplicadaI.Entidades
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }
        public string Nombre { get; set; }
        public int Inventario { get; set; }
        public Articulos()
        {
            ArticuloId = 0;
            Nombre = string.Empty;
            Inventario = 0;
        }
    }
}
