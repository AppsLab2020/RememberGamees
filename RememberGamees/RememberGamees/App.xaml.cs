using RememberGamees.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RememberGamees
{
    public partial class App : Application
    {
        private readonly ShellApp ReactionGamePage01;

        public App()
        {
            InitializeComponent();

            MainPage = new ShellApp();
        }
    }
}
