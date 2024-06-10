using System;
using System.Collections.Generic;
using System.Linq;

namespace AtticaMAUI.Models
{
    public class ArtistaService
    {
        private List<Artista> _artistas = new List<Artista>();
        private int _nextId = 1;

        private static ArtistaService _instance;
        public static ArtistaService Instance => _instance ??= new ArtistaService();

        private ArtistaService()
        {
            // Inicializamos algunos artistas de ejemplo
            Crear(new Artista
            {
                Nombre = "Leonardo da Vinci",
                Descripcion = "Uno de los más grandes genios del Renacimiento italiano.",
                Imagen = null, // Aquí puedes agregar la imagen del artista si está disponible
                ObrasDeArte = new List<ObraDeArte>() // Aquí puedes inicializar las obras de arte relacionadas
            });

            Crear(new Artista
            {
                Nombre = "Vincent van Gogh",
                Descripcion = "Famoso por sus impactantes pinturas posimpresionistas.",
                Imagen = null, // Aquí puedes agregar la imagen del artista si está disponible
                ObrasDeArte = new List<ObraDeArte>() // Aquí puedes inicializar las obras de arte relacionadas
            });
        }

        public IEnumerable<Artista> ObtenerTodos()
        {
            return _artistas;
        }

        public Artista ObtenerPorId(int id)
        {
            return _artistas.FirstOrDefault(a => a.Id == id);
        }

        public void Crear(Artista artista)
        {
            artista.Id = _nextId++;
            _artistas.Add(artista);
        }

        public void Actualizar(Artista artistaActualizado)
        {
            var artistaExistente = _artistas.FirstOrDefault(a => a.Id == artistaActualizado.Id);
            if (artistaExistente != null)
            {
                artistaExistente.Nombre = artistaActualizado.Nombre;
                artistaExistente.Descripcion = artistaActualizado.Descripcion;
                artistaExistente.Imagen = artistaActualizado.Imagen;
                // Actualizar otras propiedades según sea necesario
            }
        }

        public void Eliminar(int id)
        {
            var artista = _artistas.FirstOrDefault(a => a.Id == id);
            if (artista != null)
            {
                _artistas.Remove(artista);
            }
        }
    }
}
