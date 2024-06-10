using Microsoft.Maui;
using Microsoft.Maui.Controls;
using AtticaMAUI.Views;

namespace AtticaMAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
