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
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private async void grafMult_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void fragm_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagFragmento());
        }

        private async void ActionB_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ActionBars());
        }

        private async void tabsM_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabsMenu());
        }

        private async void Animacion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagAnima());
        }
    }
}