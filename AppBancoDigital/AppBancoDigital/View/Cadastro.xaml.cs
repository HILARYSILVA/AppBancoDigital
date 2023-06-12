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
    public partial class Cadastro : ContentPage
    {
        public Cadastro()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("AppBancoDigital.Imagem.linkedin.png");
        }

        private async void btn_Voltar_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Login());
            }

            catch (Exception ex)
            {
                await DisplayAlert("Ops, Ocorreu um erro.", ex.Message, "OK");
            }
        }

        private void dtcpk_nascimento_DateSelected(object sender, DateChangedEventArgs e)
        {

        }

        private async void btn_entrar_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync (new Login());
            }

            catch (Exception ex)
            {
                await DisplayAlert("Ops,Ocorreu um erro.", ex.Message, "OK");
            }
        }
    
    }
}