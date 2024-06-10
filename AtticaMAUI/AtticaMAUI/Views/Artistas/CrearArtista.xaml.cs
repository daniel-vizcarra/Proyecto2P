using AtticaMAUI.Models;
using Microsoft.Maui.Controls;
using System;
using System.IO;
using System.Threading.Tasks;

namespace AtticaMAUI.Views.Artistas
{
    public partial class CrearArtista : ContentPage
    {
        private readonly ArtistaService _artistaService;
        private ImageSource _imagenSeleccionada;

        public CrearArtista()
        {
            InitializeComponent();
            _artistaService = new ArtistaService();
        }

        private async void OnSeleccionarImagenClicked(object sender, EventArgs e)
        {
            var result = await FilePicker.PickAsync(new PickOptions
            {
                FileTypes = FilePickerFileType.Images,
                PickerTitle = "Seleccionar imagen del artista"
            });

            if (result != null)
            {
                using (var stream = await result.OpenReadAsync())
                {
                    _imagenSeleccionada = ImageSource.FromStream(() => stream);
                    artistaImage.Source = _imagenSeleccionada;
                }
            }
        }

        private async void OnGuardarClicked(object sender, EventArgs e)
        {
            var nuevoArtista = new Artista
            {
                Nombre = nombreEntry.Text,
                Descripcion = descripcionEditor.Text,
                Imagen = _imagenSeleccionada
            };

            _artistaService.Crear(nuevoArtista);
            await Navigation.PopAsync();
        }
    }
}
