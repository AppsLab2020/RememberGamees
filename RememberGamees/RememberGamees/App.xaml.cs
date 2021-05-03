using RememberGamees.Data;
using RememberGamees.Pages;
using System;
using System.IO;
using Xamarin.Forms;

namespace RememberGamees
{
    public partial class App : Application
    {
        static Database database;

        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "score.db3"));
                }
                return database;
            }
        }
        IAuth auth;
        public App()
        {
            InitializeComponent();
            auth = DependencyService.Get<IAuth>();
            if (auth.IsSignIn())
            {
                MainPage = new NavigationPage(new GamePage());
            }
            else
            {
                MainPage = new NavigationPage(new MainPage());
            }


            //Device.SetFlags(new[] { "Brush_Experimental" });
            //MainPage = new ShellApp();
            //MainPage = new NavigationPage(new Page1());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}