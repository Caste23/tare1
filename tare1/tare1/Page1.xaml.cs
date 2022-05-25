using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tare1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        //definimos los paramos que se van a resibir ejemplo(string result)
        public Page1(string result)
        {
            InitializeComponent();
            //definimos el parametros donde traeremos nuestros datos y lo concatemos con nuestr public
            lblresul.Text = ("su resultado es" + result);
        }
     
    }
}