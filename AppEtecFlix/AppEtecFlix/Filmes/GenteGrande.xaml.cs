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
    public partial class GenteGrande : ContentPage
    {
        public GenteGrande()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.etecflix.png");
            poster.Source = ImageSource.FromResource("AppEtecFlix.Posters.gentegrande.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width=""560"" height=""315"" src=""https://www.youtube.com/embed/HKVve_VSz58"" 
                                title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; 
                                autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; 
                                web-share"" allowfullscreen></iframe>";

            sinopse.Text = "A morte do treinador de basquete de infância de velhos " +
                "amigos reúne a turma no mesmo lugar que celebraram um " +
                "campeonato anos atrás. Os amigos, acompanhados de " +
                "suas esposas e filhos, descobrem que idade não significa o " +
                "mesmo que maturidade.";
        }
    }
}