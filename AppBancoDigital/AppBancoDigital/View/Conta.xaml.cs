﻿using AppBancoDigital.Model;
using AppBancoDigital.View.Pix;
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
    public partial class Conta : ContentPage
    {
        public Conta()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("AppBancoDigital.Imagem.linkedin.png");
            lbl_Nome.Text = "Seja bem-vindo(a) " + App.DadosCorrentista.Nome;


        }

        private void btn_Voltar_Clicked(object sender, EventArgs e)
        {

        }

        private async void btn_Voltar_Clicked_1(object sender, EventArgs e)
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





        private async void Voltar_Clicked(object sender, EventArgs e)
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

        private async void pix_Clicked(object sender, EventArgs e)
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


        private async void pix_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Areapix());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, Ocorreu um erro.", ex.Message, "OK");
            }
        }
    }
}

    
    

