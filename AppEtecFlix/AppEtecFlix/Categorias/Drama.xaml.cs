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
    public partial class Drama : ContentPage
    {
        public Drama()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.etecflix.png");

            btnACabana.Source = ImageSource.FromResource("AppEtecFlix.Posters.acabana.jpg");
            btnExtraordinario.Source = ImageSource.FromResource("AppEtecFlix.Posters.extraordinario.jpg");
            btnMeninoQueDescobriuVento.Source = ImageSource.FromResource("AppEtecFlix.Posters.meninoquedescobriuvento.jpg");
        }

        private async void Btn_Open_ACabana(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new ACabana());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...\n", ex.Message, "Ok");
            }
        }

        private async void Btn_Open_Extraordinario(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Extraordinario());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...\n", ex.Message, "Ok");
            }
        }

        private async void Btn_Open_MeninoQueDescobriuVento(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MeninoQueDescobriuVento());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...\n", ex.Message, "Ok");
            }
        }
    }
}