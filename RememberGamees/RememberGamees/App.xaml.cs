using RememberGamees.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RememberGamees
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ShellApp();
            //MainPage = new NavigationPage(new GamePage());
        }
    }
}
