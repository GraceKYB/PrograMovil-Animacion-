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
    public partial class PagAnima : ContentPage
    {
        private bool _isAnimating = false;
        public PagAnima()
        {
            InitializeComponent();
        }
        private async void IniciarAnimacion_Clicked(object sender, EventArgs e)
        {
            if (!_isAnimating)
            {
                _isAnimating = true;
                await StartAnimations();
            }
        }

        private async Task StartAnimations()
        {
            while (_isAnimating)
            {
                await Task.WhenAll(
                    AnimateBox(animatedBox1, 200, 200),
                    AnimateBox(animatedBox2, -200, 200),
                    AnimateBox(animatedBox3, 200, -200),
                    AnimateBox(animatedBox4, -200, -200)
                );
            }
        }

        private async Task AnimateBox(View box, double x, double y)
        {
            while (_isAnimating)
            {
                await box.TranslateTo(x, y, 1000);
                await box.TranslateTo(-x, -y, 1000);
            }
        }
    }
}