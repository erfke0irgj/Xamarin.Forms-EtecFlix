using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using etecflix.Filmes;

namespace etecflix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Comedia : ContentPage
    {
        public Comedia()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("etecflix.Img.logo.png");
            btnSing2.Source = ImageSource.FromResource("etecflix.Posters.sing2.jpg");
        }

        private async void Btn_Open_Sing2(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Sing2());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ocorreu um erro :(", ex.Message, "OK");
            }
        }
    }
}