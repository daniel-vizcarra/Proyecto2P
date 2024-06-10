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
            _artistaService = new ArtistaService();
            CargarArtistas();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CargarArtistas(); // Volver a cargar la lista de artistas cuando la página aparezca
        }

        private void CargarArtistas()
        {
            artistasListView.ItemsSource = _artistaService.ObtenerTodos();
        }

        private async void OnCrearNuevoArtistaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CrearArtista());
        }
    }
}
