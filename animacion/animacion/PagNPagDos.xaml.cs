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
    public partial class PagNPagDos : ContentPage
    {
        public PagNPagDos()
        {
            InitializeComponent();
        }
        private async void Regresar_Clicked(object sender, EventArgs e)
        {
            // Animar la imagen antes de navegar a la nueva página
            await AnimateImage();

            // Navegar a la nueva página
            await Navigation.PushAsync(new PaginaDos());
        }
        private async Task AnimateImage()
        {
            await animatedImage.RotateTo(360, 1000); // Rotar la imagen 360 grados en 1 segundo
            animatedImage.Rotation = 0; // Resetear la rotación
        }

    }
}