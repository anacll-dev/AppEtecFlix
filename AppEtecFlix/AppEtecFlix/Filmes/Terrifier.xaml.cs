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
    public partial class Terrifier : ContentPage
    {
        public Terrifier()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.etecflix.png");
            poster.Source = ImageSource.FromResource("AppEtecFlix.Posters.terrifier.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='560' height='315' src='https://www.youtube.com/embed/DotHFemS-kg' 
                                title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; 
                                clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share' allowfullscreen>
                                </iframe>";

            sinopse.Text = "Enquanto cuida de duas crianças no halloween, uma babá " +
                "encontra uma antiga fita VHS no saco de doces. O filme " +
                "apresenta três contos de terror, todos ligados entre si por " +
                "um palhaço assassino. Ao longo da noite, coisas estranhas " +
                "começam a acontecer na casa e a presença do palhaço " +
                "parece cada vez mais real.";
        }
    }
}