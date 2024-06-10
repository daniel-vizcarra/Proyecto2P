using System;
using System.Collections.Generic;
using System.Linq;

namespace AtticaMAUI.Models
{
    public class ObraDeArteService
    {
        private List<ObraDeArte> _obrasDeArte = new List<ObraDeArte>();
        private int _nextId = 1;

        public ObraDeArteService()
        {
            // Puedes inicializar algunas obras de arte de ejemplo aquí
        }

        public IEnumerable<ObraDeArte> ObtenerTodos()
        {
            return _obrasDeArte;
        }

        public ObraDeArte ObtenerPorId(int id)
        {
            return _obrasDeArte.FirstOrDefault(o => o.Id == id);
        }

        public void Crear(ObraDeArte obraDeArte)
        {
            obraDeArte.Id = _nextId++;
            _obrasDeArte.Add(obraDeArte);
        }

        public void Actualizar(ObraDeArte obraDeArteActualizada)
        {
            var obraDeArteExistente = _obrasDeArte.FirstOrDefault(o => o.Id == obraDeArteActualizada.Id);
            if (obraDeArteExistente != null)
            {
                obraDeArteExistente.Titulo = obraDeArteActualizada.Titulo;
                // Actualizar otras propiedades según sea necesario
            }
        }

        public void Eliminar(int id)
        {
            var obraDeArte = _obrasDeArte.FirstOrDefault(o => o.Id == id);
            if (obraDeArte != null)
            {
                _obrasDeArte.Remove(obraDeArte);
            }
        }
    }
}
