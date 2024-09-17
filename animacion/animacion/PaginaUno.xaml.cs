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
    public partial class PaginaUno : ContentPage
    {
        private Random random;

        public PaginaUno()
        {
            InitializeComponent();
            random = new Random();
        }

        private void LanzarDados_Clicked(object sender, EventArgs e)
        {
            int dado1 = random.Next(1, 7);
            int dado2 = random.Next(1, 7);
            int resultado = dado1 + dado2;

            estadoLabel.Text = $"Dados lanzados: {dado1} y {dado2}\nResultado: {resultado}";
        }

        private void ReiniciarJuego_Clicked(object sender, EventArgs e)
        {
            estadoLabel.Text = "¡Bienvenido al Juego!";
        }
    }
}