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
    public partial class AMaldicaoDeChucky : ContentPage
    {
        public AMaldicaoDeChucky()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.etecflix.png");
            poster.Source = ImageSource.FromResource("AppEtecFlix.Posters.amaldicaodechucky.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width=""560"" height=""315"" src=""https://www.youtube.com/embed/vimoKw88brc"" 
                                title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; 
                                autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; 
                                web-share"" allowfullscreen></iframe>";

            sinopse.Text = "Depois do suicídio de sua mãe, Nica recebe a visita de sua " +
                "autoritária irmã Barb, que pretende ajudar nos arranjos do " +
                "funeral. Sua filha traz um boneco ruivo que chegou " +
                "curiosamente pelos correios. Quando uma série de " +
                "assassinatos aterrorizam a vizinhança, Nica começa a " +
                "suspeitar que o brinquedo tenha alguma relação com estes " +
                "fatos, mas não sabe que Chucky está de volta para " +
                "resolver casos pessoais de mais de vinte anos atrás.";
        }
    }
}