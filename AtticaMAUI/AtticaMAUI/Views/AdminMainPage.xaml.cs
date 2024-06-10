namespace AtticaMAUI.Views;

public partial class AdminMainPage : ContentPage
{
	public AdminMainPage()
	{
		InitializeComponent();


    }
    private async void OnObrasClicked(object sender, EventArgs e)
    {
        // Navegar a la p�gina de obras
        await Navigation.PushAsync(new ObrasDeArtePage());
    }
    private async void OnArtistasClicked(object sender, EventArgs e)
    {
        // Aqu� puedes navegar a la p�gina de artistas
        await Navigation.PushAsync(new ArtistasPage());
    }
}