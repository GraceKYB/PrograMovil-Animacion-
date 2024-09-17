using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace animacion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaAction : ContentPage
    {
        public PaginaAction()
        {
            InitializeComponent();
            StartImageAnimation();
        }

        private async void ButtonEnviar_Clicked(object sender, EventArgs e)
        {
            string nombre = entryNombre.Text; // Obtener el texto ingresado en el Entry

            if (!string.IsNullOrWhiteSpace(nombre))
            {
                // Mostrar un mensaje de alerta con el nombre ingresado
                await DisplayAlert("Mensaje", $"¡Hola, {nombre}!", "OK");
            }
            else
            {
                // Mostrar un mensaje de alerta si no se ingresó ningún nombre
                await DisplayAlert("Error", "Debe ingresar un nombre.", "OK");
            }
        }

        private async void StartImageAnimation()
        {
            while (true) // Bucle infinito para la animación continua
            {
                await Task.WhenAll(
                    animatedImage.RotateTo(360, 2000), // Rotar 360 grados en 2 segundos
                    animatedImage.ScaleTo(1.5, 1000),  // Aumentar el tamaño a 1.5x en 1 segundo
                    animatedImage.TranslateTo(100, 100, 2000) // Mover a (100, 100) en 2 segundos
                );

                await Task.WhenAll(
                    animatedImage.RotateTo(0, 2000),   // Volver a 0 grados en 2 segundos
                    animatedImage.ScaleTo(1, 1000),    // Volver al tamaño original en 1 segundo
                    animatedImage.TranslateTo(0, 0, 2000)  // Volver a la posición original en 2 segundos
                );
            }
        }
    }
}