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
    public partial class PagFragmento : ContentPage
    {
        public PagFragmento()
        {
            InitializeComponent();
        }
        private void fragm_Clicked(object sender, System.EventArgs e)
        {
            // Limpiar el contenedor antes de agregar el fragmento
            fragmentContainer.Children.Clear();

            // Crear e agregar el fragmento al contenedor
            var fragmento = new fragmento();
            fragmentContainer.Children.Add(fragmento);
        }
    }
}