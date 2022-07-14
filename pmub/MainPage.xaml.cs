using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using pmub;

using System.Collections;
using MySql.Data.MySqlClient;
 
namespace pmub
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            
            InitializeComponent();
        }
        private async void OpenInscriptionPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inscriptions());

        }

        private async void BtnConnexion_Clicked(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Constants.connectionString);
            await conn.OpenAsync();

            MySqlCommand cmd = new MySqlCommand(Constants.selectUser, conn);
            cmd.Connection = conn;

            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                await Navigation.PushAsync(new Accueil());
          
            }


        }
    }
}
