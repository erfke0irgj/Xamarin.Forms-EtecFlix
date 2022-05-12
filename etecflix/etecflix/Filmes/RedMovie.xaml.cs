using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace etecflix.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RedMovie : ContentPage
    {
        public RedMovie()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("etecflix.Img.logo.png");
            poster.Source = ImageSource.FromResource("etecflix.Posters.red_movie.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='400' height='300'
                                src='https://www.youtube.com/embed/YeQoQNZq7wg'
                                title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen>
                                </iframe>";

            viewer.Source = htmlSource;

            sinopse.Text = "Mei é uma garota que vive o auge de seus 13 anos no começo dos anos 2000. Inexplicavelmente, ela passa a se transformar num gigante panda vermelho sempre que fica nervosa ou animada (o que é uma constante).";
        }
    }
}