using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pmub
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Accueil : ContentPage
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private async void OpenPariPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Paris());
        }
        private async void OpenDepotPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Depots());

        }
        private async void OpenSoldePage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Solde());

        }
        private async void OpenRetraitPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Retraits());

        }
        private async void Deconnexion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}