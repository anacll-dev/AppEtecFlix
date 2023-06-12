using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEtecFlix.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MeninoQueDescobriuVento : ContentPage
    {
        public MeninoQueDescobriuVento()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.etecflix.png");
            poster.Source = ImageSource.FromResource("AppEtecFlix.Posters.meninoquedescobriuvento.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width=""560"" height=""315"" src=""https://www.youtube.com/embed/OBprnlpM744"" 
                                title=""YouTube video player"" frameborder=""0"" allow=""accelerometer;
                                autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; 
                                web-share"" allowfullscreen></iframe>";

            sinopse.Text = "Sempre esforçando-se para adquirir conhecimentos " +
                "diversificados, um jovem de Malawi se cansa de assistir " +
                "todos os colegas de seu vilarejo passando por dificuldades" +
                "e começa a desenvolver uma inovadora turbina de vento";
        }
    }
}