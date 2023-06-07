using AppEtecFlix.Filmes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEtecFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Comedia : ContentPage
    {
        public Comedia()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.etecflix.png");

            btnAsBranquelas.Source = ImageSource.FromResource("AppEtecFlix.Posters.asbranquelas.jpg");
            btnAmericanPie.Source = ImageSource.FromResource("AppEtecFlix.Posters.americanpie.jpg");
            btnGenteGrande.Source = ImageSource.FromResource("AppEtecFlix.Posters.gentegrande.jpg");
        }

        private async void Btn_Open_AsBranquelas(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AsBranquelas());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...\n", ex.Message, "Ok");
            }
        }

        private async void Btn_Open_AmericanPie(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AmericanPie());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...\n", ex.Message, "Ok");
            }
        }

        private async void Btn_Open_GenteGrande(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new GenteGrande());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...\n", ex.Message, "Ok");
            }
        }
    }
}