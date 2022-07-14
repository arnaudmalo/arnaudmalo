using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections;
using MySql.Data.MySqlClient;


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
            MySqlConnection conn = new MySqlConnection(Constants.connectionString);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = Constants.insertUsers;
            cmd.Parameters.Add("@User", MySqlDbType.VarChar).Value = Entry_Utilisateur;
            cmd.Parameters.Add("@UsersName", MySqlDbType.VarChar).Value = Entry_NomUtilisateur;
            cmd.Parameters.Add("@UsersPrenoms", MySqlDbType.VarChar).Value = Entry_PrenomUtilisateur;
            cmd.Parameters.Add("@UsersTel", MySqlDbType.VarChar).Value = Entry_TelephoneUtilisateur;
            cmd.Parameters.Add("@UsersPass", MySqlDbType.VarChar).Value = Entry_MotdePasse;

            await cmd.ExecuteNonQueryAsync();

           

            var Message = DisplayAlert("Alerte", "Inscription fait", "OK");
            Console.Write(Message);
            

            await Navigation.PushAsync(new Accueil());
            await App.UserRepositories.AddNewUserInTable(Entry_Utilisateur.Text, Entry_NomUtilisateur.Text, Entry_PrenomUtilisateur.Text, Entry_TelephoneUtilisateur.Text, Entry_MotdePasse.Text );

           
        }
    }
}