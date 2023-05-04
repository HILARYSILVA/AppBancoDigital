using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

            logo.Source = ImageSource.FromResource("AppBancoDigital.Imagem.linkedin.png");
        }

        private void btn_ir_Clicked(object sender, EventArgs e)
        {

        }
    }
}