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
    public partial class AmericanPie : ContentPage
    {
        public AmericanPie()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.etecflix.png");
            poster.Source = ImageSource.FromResource("AppEtecFlix.Posters.americanpie.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='560' height='315' 
                                src='https://www.youtube.com/embed/vogHAynN9Ms' title='YouTube video player'
                                frameborder='0' allow='accelerometer; autoplay; clipboard-write;
                                encrypted-media; gyroscope; picture-in-picture; web-share'
                                allowfullscreen></iframe>";

            sinopse.Text = "Mesmo que Jim e Michelle namorem há vários anos, ela" +
                "ainda fica surpresa quando ele pede sua mão em " +
                "casamento em seu restaurante favorito. Depois que ela " +
                "alegremente concorda, Jim pede aos seus melhores " +
                "amigos, Kevin e Paul, para ajudá - lo a ter certeza de que " +
                "tudo dê certo no dia do casamento.Com a aproximação do " +
                "grande dia, um problema surge quando o trio descobre que " +
                "seu amigo Stifler está na cidade.";
        }
    }
}