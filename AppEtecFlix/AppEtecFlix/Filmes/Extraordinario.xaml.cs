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
    public partial class Extraordinario : ContentPage
    {
        public Extraordinario()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.etecflix.png");
            poster.Source = ImageSource.FromResource("AppEtecFlix.Posters.extraordinario.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width=""560"" height=""315"" src=""https://www.youtube.com/embed/6g80d7igX0k"" 
                                title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; 
                                autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; 
                                web-share"" allowfullscreen></iframe>";

            sinopse.Text = "Auggie Pullman é um garoto que nasceu com uma " +
                "deformidade facial e precisou passar por 27 cirurgias " +
                "plásticas. Aos 10 anos, ele finalmente começa a frequentar " +
                "uma escola regular, como qualquer outra criança, pela " +
                "primeira vez. No quinto ano, ele precisa se esforçar para " +
                "conseguir se encaixar em sua nova realidade.";
        }
    }
}