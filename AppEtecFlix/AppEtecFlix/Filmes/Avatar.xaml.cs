using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEtecFlix.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Avatar : ContentPage
    {
        public Avatar()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.etecflix.png");
            poster.Source = ImageSource.FromResource("AppEtecFlix.Posters.avatar.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='560' height='315' 
                                src='https://www.youtube.com/embed/ImtK7O32xS0' title='YouTube video player' 
                                frameborder='0' allow='accelerometer; autoplay; clipboard-write; 
                                encrypted-media; gyroscope; picture-in-picture; web-share'
                                allowfullscreen></iframe>";

            sinopse.Text = "No exuberante mundo alienígena de Pandora vivem os" +
                           "Na'vi, seres que parecem ser primitivos, mas são altamente" +
                           "evoluídos. Como o ambiente do planeta é tóxico, foram" +
                           "criados os avatares, corpos biológicos controlados pela" +
                           "mente humana que se movimentam livremente em" +
                           "Pandora. Jake Sully, um ex-fuzileiro naval paralítico, volta a" +
                           "andar através de um avatar e se apaixona por uma Na'vi." +
                           "Esta paixão leva Jake a lutar pela sobrevivência de" +
                           "Pandora.";
        }
    }
}