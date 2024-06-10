using System.Linq;
using AtticaMAUI.Models;
using AtticaMAUI.Views.Artistas;
using Microsoft.Maui.Controls;

namespace AtticaMAUI.Views
{
    public partial class ArtistasPage : ContentPage
    {
        private readonly ArtistaService _artistaService;

        public ArtistasPage()
        {
            InitializeComponent();
            _artistaService = ArtistaService.Instance; // Usamos la instancia singleton
            CargarArtistas();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CargarArtistas(); // Recargamos los artistas cada vez que la página aparece
        }

        private void CargarArtistas()
        {
            artistasListView.ItemsSource = _artistaService.ObtenerTodos().ToList();
        }

        private async void OnCrearNuevoArtistaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CrearArtista());
        }
    }
}
