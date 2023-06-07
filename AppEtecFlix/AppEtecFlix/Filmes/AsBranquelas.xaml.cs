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
    public partial class AsBranquelas : ContentPage
    {
        public AsBranquelas()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.etecflix.png");
            poster.Source = ImageSource.FromResource("AppEtecFlix.Posters.asbranquelas.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='560' height='315' 
                                src='https://www.youtube.com/embed/seoJIPLLWp0' title='YouTube video player'
                                frameborder='0' allow='accelerometer; autoplay; clipboard-write; 
                                encrypted-media; gyroscope; picture-in-picture; web-share' allowfullscreen></iframe>";

            sinopse.Text = "Dois irmãos agentes do FBI, Marcus e Kevin Copeland," +
                           "acidentalmente evitam que bandidos sejam presos em uma" +
                           "apreensão de drogas. Como castigo, eles são forçados a" +
                           "escoltar um par de socialites nos Hamptons. Quando as" +
                           "meninas descobrem o plano da agência, elas se recusam a" +
                           "ir. Sem opções, Marcus e Kevin, dois homens negros," +
                           "decidem fingir que são as irmãs e se transformam em um" +
                           "par de loiras.";
        }
    }
}