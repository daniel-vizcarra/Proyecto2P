using System;
using AtticaMAUI.Models;
using Microsoft.Maui.Controls;

namespace AtticaMAUI.Views.Artistas
{
    public partial class CrearArtista : ContentPage
    {
        private readonly ArtistaService _artistaService;

        public CrearArtista()
        {
            InitializeComponent();
            _artistaService = ArtistaService.Instance; // Usamos la instancia singleton
        }

        private async void OnGuardarClicked(object sender, EventArgs e)
        {
            var nuevoArtista = new Artista
            {
                Nombre = nombreEntry.Text,
                Descripcion = descripcionEditor.Text,
                Imagen = null, // Aquí puedes agregar lógica para convertir la URL a byte[]
                ObrasDeArte = new List<ObraDeArte>()
            };

            _artistaService.Crear(nuevoArtista);

            await DisplayAlert("Éxito", "Artista creado exitosamente", "OK");
            await Navigation.PopAsync();
        }

        private async void OnCancelarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
