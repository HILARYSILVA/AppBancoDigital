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
    public partial class Pix : ContentPage
    {

        public Pix()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("AppBancoDigital.Imagem.linkedin.png");


        }

        private async void Voltar_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Conta());
            }
            catch (Exception ex)
            {
               await DisplayAlert("Ops, Ocorreu um erro.", ex.Message, "OK");
            }
        }
    }
}