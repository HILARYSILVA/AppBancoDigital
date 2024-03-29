﻿using AppBancoDigital.View.Pix;
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
    public partial class Areapix : ContentPage
    {
        public Areapix()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("AppBancoDigital.Imagem.linkedin.png");
        }

        private async void LerQrCode_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new EnviarPix());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, Ocorreu um erro.", ex.Message, "OK");
            }
        }

        private async void ExibirQrCode_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new PixLerQrCode());

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
                await Navigation.PushAsync(new Conta());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, Ocorreu um erro.", ex.Message, "OK");
            }
        }

        private async void Chavepix_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Chavep());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, Ocorreu um erro.", ex.Message, "OK");
            }
        }
    }
}