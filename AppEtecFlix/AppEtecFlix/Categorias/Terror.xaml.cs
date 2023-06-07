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
    public partial class Terror : ContentPage
    {
        public Terror()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.etecflix.png");

            btnPanico5.Source = ImageSource.FromResource("AppEtecFlix.Posters.panico5.jpg");
            btnTerrifier.Source = ImageSource.FromResource("AppEtecFlix.Posters.terrifier.jpg");
            btnAMaldicaoDeChucky.Source = ImageSource.FromResource("AppEtecFlix.Posters.amaldicaodechucky.jpg");
        }

        private async void Btn_Open_Panico5(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Panico5());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...\n", ex.Message, "Ok");
            }
        }

        private async void Btn_Open_Terrifier(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Terrifier());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...\n", ex.Message, "Ok");
            }
        }

        private async void Btn_Open_AMaldicaoDeChucky(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AMaldicaoDeChucky());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...\n", ex.Message, "Ok");
            }
        }
    }
}