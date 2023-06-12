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
    public partial class ACabana : ContentPage
    {
        public ACabana()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.etecflix.png");
            poster.Source = ImageSource.FromResource("AppEtecFlix.Posters.acabana.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='560' height='315' src='https://www.youtube.com/embed/1OierkhAbpc' 
                                title='YouTube video player' frameborder='0' allow='accelerometer; 
                                autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; 
                                web-share' allowfullscreen></iframe>";

            sinopse.Text = "Um homem vive atormentado após perder a sua filha mais " +
                "nova, cujo corpo nunca foi encontrado, mas sinais de que " +
                "ela teria sido violentada e assassinada são encontrados em " +
                "uma cabana nas montanhas. Anos depois da tragédia, ele " +
                "recebe um chamado misterioso para retornar a esse local, " +
                "onde ele vai receber uma lição de vida.";
        }
    }
}