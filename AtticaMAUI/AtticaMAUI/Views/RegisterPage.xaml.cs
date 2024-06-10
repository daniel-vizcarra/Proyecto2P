using Microsoft.Maui.Controls;
using AtticaMAUI.Models;

namespace AtticaMAUI.Views
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                await DisplayAlert("Error", "Please enter username and password", "OK");
                return;
            }

            bool registered = AuthService.Instance.Register(username, password, UserRole.Customer);

            if (registered)
            {
                await DisplayAlert("Success", "User registered successfully", "OK");
                await Navigation.PopAsync(); // Regresar a la página anterior después del registro exitoso
            }
            else
            {
                await DisplayAlert("Error", "Username already exists", "OK");
            }
        }
    }
}
