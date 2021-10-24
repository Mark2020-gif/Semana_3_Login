using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Loginpage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageDos : ContentPage
    {
        public PageDos()
        {
            InitializeComponent();
        }

        private void btnSumar_Clicked(object sender, EventArgs e)
        {
            try
            {
                double valor1 = Convert.ToDouble(txtValorUno.Text);
                double valor2 = Convert.ToDouble(txtValorDos.Text);
                //Operacion
                double suma = valor1 + valor2;
                //Visualizar el resultado en pantalla
                txtResultado.Text = suma.ToString();

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de alerta", ex.Message, "OK");
            }

        }
    }
}