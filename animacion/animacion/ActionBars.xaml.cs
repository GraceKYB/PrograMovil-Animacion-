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
    public partial class ActionBars : ContentPage
    {
        public ActionBars()
        {
            InitializeComponent();
        }
        private async void ToolbarItem_Clicked(object sender, System.EventArgs e)
        {
            // Lógica para manejar la acción del botón de la barra de herramientas
            await DisplayAlert("Acción", "Realizando acción desde la barra de herramientas", "OK");

            // Animación de la imagen cuando se hace clic en la barra de herramientas
            await imgIcono.RotateTo(360, 1000); // Girar la imagen 360 grados en 1 segundo
            await imgIcono.ScaleTo(2, 500); // Escalar la imagen al doble de su tamaño original en 0.5 segundos
            await imgIcono.ScaleTo(1, 500); // Restaurar la imagen a su tamaño original en 0.5 segundos
        }
        private async void IrAOtraPagina_Clicked(object sender, System.EventArgs e)
        {
            // Navegar a otra página dentro de la misma aplicación
            await Navigation.PushAsync(new PaginaAction());
        }
    }
}