using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using pmub;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace pmub.Models
{
    public class UsersRepositories
    {




        //string adressBd = "172.19.192.1";
        //SqlConnection con = new SqlConnection();

        private SQLiteAsyncConnection connection;
        public string StatusMessage { get; set; }
        public UsersRepositories(string dbpath)
        {
            connection = new SQLiteAsyncConnection(dbpath);
            connection.CreateTableAsync<Users>();
        }

        public async Task AddNewUserInTable(string userName, string user, string userPrenoms, string userTel, string userPass)
        {
            int resultat = 0;

            try
            {
                resultat = await connection.InsertAsync(new Users { UsersName = userName, User=user, UsersPrenoms = userPrenoms, UsersTel = userTel , UsersPass= userPass}) ;

                StatusMessage = $"{resultat} Nouvel Utilisateur \n Bienvenue: {userName}";

                // Distance

            }
            catch (Exception ex)
            {
                StatusMessage = $"{resultat} Impossible d'ajouter l'utilisateur : {userName}\n  : {ex.Message}";
            }
     
        }

        public async Task<List<Users>> GetUsersAsync()
        {
            try
            {
                return await connection.Table<Users>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = $" Impossible d'avoir le nom de l'utilisateur : \n  : {ex.Message}";
            }

            return new List<Users>();

        }
        

    }
}
