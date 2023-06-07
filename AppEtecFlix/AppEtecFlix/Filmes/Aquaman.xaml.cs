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
    public partial class Aquaman : ContentPage
    {
        public Aquaman()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.etecflix.png");
            poster.Source = ImageSource.FromResource("AppEtecFlix.Posters.aquaman.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='560' height='315' 
                                src='https://www.youtube.com/embed/yJnzCBt5j1M' title='YouTube video player'
                                frameborder='0' allow='accelerometer; autoplay; clipboard-write; 
                                encrypted-media; gyroscope; picture-in-picture; web-share' 
                                allowfullscreen></iframe>";

            sinopse.Text = "A cidade de Atlantis, que já foi lar de uma das mais" +
                           "avançadas civilizações do mundo, agora é um reino" +
                           "submerso dominado pelo ganancioso Rei Orm. Com um" +
                           "vasto exército a seu dispor, Orm planeja conquistar tanto os" +
                           "demais reinos do oceano, quanto o mundo da superfície." +
                           "Em seu caminho está Aquaman, meio-humano e meio-" +
                           "atlante, e verdadeiro herdeiro do trono. Com a ajuda da" +
                           "princesa Mera, Aquaman precisa recuperar o lendário" +
                           "Tridente de Atlan e aceitar seu destino como protetor das profundezas.";
        }
    }
}