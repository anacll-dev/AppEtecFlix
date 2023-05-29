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
    public partial class GatodeBotas2 : ContentPage
    {
        public GatodeBotas2()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.etecflix.png");
            poster.Source = ImageSource.FromResource("AppEtecFlix.Posters.gatodebotas2.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='560' height='315'
                                src='https://www.youtube.com/embed/sLk94T-hS78?controls=0' 
                                title='YouTube video player' frameborder='0' allow='accelerometer; 
                                autoplay; 
                                clipboard-write; encrypted-media; gyroscope;
                                picture-in-picture; web-share'' allowfullscreen></iframe>";

            sinopse.Text = "O Gato de Botas descobre que sua paixão pela aventura" +
                           "cobrou seu preço: ele já gastou oito de suas nove vidas." +
                           "Ele então parte em uma jornada épica para encontrar o" +
                           "mítico Último Desejo e restaurar suas nove vidas.";

        }
    }
}