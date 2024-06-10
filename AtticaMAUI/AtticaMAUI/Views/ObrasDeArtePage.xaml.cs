using System;
using AtticaMAUI.Models;
using Microsoft.Maui.Controls;

namespace AtticaMAUI.Views
{
    public partial class ObrasDeArtePage : ContentPage
    {
        public ObrasDeArtePage()
        {
            InitializeComponent();
        }

        private void OnEditarClicked(object sender, EventArgs e)
        {
            // Obtener la obra de arte asociada al bot�n "Editar" que se hizo clic
            var obra = (sender as Button)?.CommandParameter as ObraDeArte;
            if (obra != null)
            {
                // Aqu� puedes implementar la l�gica para editar la obra de arte (navegar a una p�gina de edici�n, por ejemplo)
                // Por ahora, mostraremos un mensaje de alerta
                DisplayAlert("Editar", $"Editar obra de arte: {obra.Titulo}", "OK");
            }
        }

        private void OnEliminarClicked(object sender, EventArgs e)
        {
            // Obtener la obra de arte asociada al bot�n "Eliminar" que se hizo clic
            var obra = (sender as Button)?.CommandParameter as ObraDeArte;
            if (obra != null)
            {
                // Aqu� puedes implementar la l�gica para eliminar la obra de arte
                // Por ahora, mostraremos un mensaje de alerta
                DisplayAlert("Eliminar", $"Eliminar obra de arte: {obra.Titulo}", "OK");
            }
        }
    }
}
