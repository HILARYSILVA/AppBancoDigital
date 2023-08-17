﻿using AppBancoDigital.Service;
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

        private void btn_ir_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.Login());

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
            string[] cpf_pontuado = txt_cpf.Text.Split('.', '-');
            string cpf_digitado = cpf_pontuado[0] + cpf_pontuado[1] + cpf_pontuado[2] + cpf_pontuado[3];

            try
            {
                Model.Correntista c = await DataServiceCorrentista.LoginAsync(new Model.Correntista
                {
                    Cpf = cpf_digitado,
                    Senha = txt_senha.Text,
                });

                if (c.Id != null)
                {
                    App.DadosCorrentista = c;
                    App.Current.MainPage = new NavigationPage(new View.Cadastro());

                }
                else
                    throw new Exception("Dados de login inválidos.");

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

    }
}