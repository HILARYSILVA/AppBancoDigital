using AppBancoDigital.Service;
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

            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("AppBancoDigital.Imagem.linkedin.png");
        }

        private async void btn_ir_Clicked(object sender, EventArgs e)
        {
            try
            {
                Model.Correntista c = await DataServiceCorrentista.LoginAsync(new Model.Correntista
                {
                    Cpf = txt_cpf.Text.Replace(".", "").Replace("-", ""),
                    Senha = txt_senha.Text,
                }); ;

                if (c.Id != null)
                {
                    App.DadosCorrentista = c;
                    App.Current.MainPage = new NavigationPage(new View.Conta());

                }
                else
                    throw new Exception("Dados de login inválidos.");

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }



        private async void btn_Voltar_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Menu());
            }

            catch (Exception ex)
            {
                await DisplayAlert("Ops, Ocorreu um erro.", ex.Message, "OK");
            }
        }


        private async void btn_cadastrar_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cadastro());
        }

    }
}