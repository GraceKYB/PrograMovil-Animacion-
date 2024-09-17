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
    public partial class fragmento : ContentView
    {
        public fragmento()
        {
            InitializeComponent();
        }
        private void CerrarFragmento_Clicked(object sender, EventArgs e)
        {
            // Evento para cerrar el fragmento
            var parent = this.Parent as Layout<View>;
            parent.Children.Remove(this);


        }
    }
}