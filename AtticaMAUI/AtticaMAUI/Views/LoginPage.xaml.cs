using Microsoft.Maui.Controls;
using AtticaMAUI.Models;

namespace AtticaMAUI.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                await DisplayAlert("Error", "Please enter username and password", "OK");
                return;
            }

            UserRole role = AuthService.Instance.GetRole(username, password);

            if (role == UserRole.Admin)
            {
                // Iniciar sesión como administrador
                await Navigation.PushAsync(new AdminMainPage());
            }
            else if (role == UserRole.Customer)
            {
                // Iniciar sesión como cliente
                await Navigation.PushAsync(new CustomerMainPage());
            }
            else
            {
                // Credenciales inválidas
                await DisplayAlert("Error", "Invalid username or password", "OK");
            }
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            // Navegar a la página de registro
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}
