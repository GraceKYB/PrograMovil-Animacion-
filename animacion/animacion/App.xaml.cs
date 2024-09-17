using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace animacion
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            // Establecer la página principal
            MainPage = new NavigationPage(new SplashPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
