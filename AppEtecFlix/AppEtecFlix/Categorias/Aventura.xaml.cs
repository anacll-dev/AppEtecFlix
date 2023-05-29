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
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.etecflix.png");

            btnGatoDeBotas2.Source = ImageSource.FromResource("AppEtecFlix.Posters.gatodebotas2.jpg");
            btnAquaman.Source = ImageSource.FromResource("AppEtecFlix.Posters.aquaman.jpg");
            btnAvatar.Source = ImageSource.FromResource("AppEtecFlix.Posters.avatar.jpg");

            
        }

        private async void Btn_Open_GatodeBotas2(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new GatodeBotas2());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...\n", ex.Message, "Ok");
            }
        }

        private async void Btn_Open_Aquaman(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Aquaman());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...\n", ex.Message, "Ok");
            }
        }

        private async void Btn_Open_Avatar(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Avatar());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...\n", ex.Message, "Ok");
            }
        }
    }


}