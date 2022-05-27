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
    public partial class Inscriptions : ContentPage
    {
        public Inscriptions()
        {
            InitializeComponent();
        }

        private async void ValiderInscription_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Accueil());
        }
    }
}