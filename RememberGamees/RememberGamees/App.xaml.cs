using RememberGamees;

using RememberGamees.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RememberGamees
{
    public partial class App : Application
    {
        private readonly ShellApp ReactionGamePage01;

        IAuth auth;
        public App()
        {
            InitializeComponent();
            auth = DependencyService.Get<IAuth>();
            if (auth.IsSignIn())
            {
                MainPage = new GamePage();
            }
            else
            {
                MainPage = new MainPage();
            }
            //Device.SetFlags(new[] { "Brush_Experimental" });
            //MainPage = new ShellApp();
            //MainPage = new NavigationPage(new Page1());
        }
    }
}
