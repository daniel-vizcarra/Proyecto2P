namespace AtticaMAUI.Views;

public partial class AdminMainPage : ContentPage
{
	public AdminMainPage()
	{
		InitializeComponent();


    }
    private async void OnObrasClicked(object sender, EventArgs e)
    {
        // Navegar a la página de obras
        await Navigation.PushAsync(new ObrasDeArtePage());
    }
    private async void OnArtistasClicked(object sender, EventArgs e)
    {
        // Aquí puedes navegar a la página de artistas
        await Navigation.PushAsync(new ArtistasPage());
    }
}