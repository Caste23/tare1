using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace tare1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public MainPage(DateTime date)
        {
            InitializeComponent();
        }

        private async void btnsumar_Clicked(object sender, EventArgs e)
        {
            //capturamos los parametros de nuestro text uno y dos
            var uno = double.Parse(txtuno.Text);
            var dos = double.Parse(txtdos.Text);
            var suma = uno + dos;
            await Navigation.PushAsync(new Page1(": "+suma));
        }

        private async void btnrestar_Clicked(object sender, EventArgs e)
        {
            //capturamos los parametros de nuestro text uno y dos
            int uno = Convert.ToInt32(txtuno.Text);
            int dos = Convert.ToInt32(txtdos.Text);
            int resta = uno - dos;
            await Navigation.PushAsync(new Page1(": " + resta));

        }
        //le desimos que sea asincrono(async) para tener navigation entre otra pantalla
        private async void btnmult_Clicked(object sender, EventArgs e)
        {
            //capturamos los parametros de nuestro text uno y dos
            int uno = Convert.ToInt32(txtuno.Text);
            int dos = Convert.ToInt32(txtdos.Text);
            int resta = uno * dos;
            //Enviamos el resultado a otra pantalla
            await Navigation.PushAsync(new Page1(": " + resta));
        }
        //le desimos que sea asincrono(async) para tener navigation entre otra pantalla
        private async void btndiv_Clicked(object sender, EventArgs e)
        {
            //capturamos los parametros de nuestro text uno y dos
            int uno = Convert.ToInt32(txtuno.Text);
            int dos = Convert.ToInt32(txtdos.Text);
            int division = uno / dos;
            //Enviamos el resultado a otra pantalla
            await Navigation.PushAsync(new Page1(": " + division));

        }
    }
}
