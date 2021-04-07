using RememberGamees;
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
            Device.SetFlags(new[] { "Brush_Experimental" });
            MainPage = new ShellApp();
            //MainPage = new Page1();
        }
    }
}
