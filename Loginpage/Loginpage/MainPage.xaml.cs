using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Loginpage
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String sUsuario = txtUsuario.Text;
            String sPassword = txtPassword.Text;

            if((sUsuario == "estudiante2021") && (sPassword == "uisrael2021"))
            {
                Navigation.PushAsync(new PageDos());
            }
            else
            {
                lblResultado.Text = "El usuario o Password es incorrecto";
            }

        }
    }
}
