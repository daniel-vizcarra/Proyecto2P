using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace AtticaMAUI.Models
{
    public class Artista
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public ImageSource? Imagen { get; set; } // Imagen del artista
        public string? Descripcion { get; set; }
        public List<ObraDeArte>? ObrasDeArte { get; set; }
    }
}
