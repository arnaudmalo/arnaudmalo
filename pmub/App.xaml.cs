using pmub.Models;
using System;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pmub
{
    public partial class App : Application
    {
        private string dbPath = Path.Combine(FileSystem.AppDataDirectory, "database.db3");
        public static UsersRepositories UserRepositories {get; set;}

        public App()
        {
            InitializeComponent();

            UserRepositories = new UsersRepositories(dbPath);
            MainPage = new NavigationPage(new MainPage());
        }
        protected override void OnStart()
        {
        }
        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
