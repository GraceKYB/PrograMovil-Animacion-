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
    public partial class TabsMenu : TabbedPage
    {
        public TabsMenu()
        {
            InitializeComponent();

            Children.Add(new PaginaUno());
            Children.Add(new PaginaDos());
        }
    }
}