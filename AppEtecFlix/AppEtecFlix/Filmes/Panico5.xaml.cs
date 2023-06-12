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
    public partial class Panico5 : ContentPage
    {
        public Panico5()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.etecflix.png");
            poster.Source = ImageSource.FromResource("AppEtecFlix.Posters.panico5.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='560' height='315' src='https://www.youtube.com/embed/1OierkhAbpc' 
                                title='YouTube video player' frameborder='0' allow='accelerometer; 
                                autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; 
                                web-share' allowfullscreen></iframe>";

            sinopse.Text = "Vinte e cinco anos após uma série de crimes brutais chocar " +
                "a tranquila Woodsboro, um novo assassino se apropria da " +
                "máscara de Ghostface e começa a perseguir um grupo de " +
                "adolescentes para trazer à tona segredos do passado " +
                "mortal da cidade.";
        }
    }
}