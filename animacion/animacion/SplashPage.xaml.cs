using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace animacion
{
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();
            AnimateSplashImage();
        }

        private async void AnimateSplashImage()
        {
            await SplashImage.FadeTo(1, 2000); // Desvanece la imagen en 2 segundos
            await Task.Delay(1000); // Espera 1 segundo
            Application.Current.MainPage = new NavigationPage(new Inicio()); // Navega a la página de inicio de sesión
        }
    }
}
