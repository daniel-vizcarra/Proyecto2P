using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtticaMAUI.Models
{
    public class ObraDeArte
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        // Otras propiedades de la obra de arte
        public byte[]? Imagen { get; set; } // Imagen de la obra de arte en formato byte[]
        public string? Descripcion { get; set; } // Descripción de la obra de arte
        // Otros detalles de la obra de arte

        public int ArtistaId { get; set; } // Clave foránea para la relación con el artista
        public Artista? Artista { get; set; } // Propiedad de navegación hacia el artista
    }
}
