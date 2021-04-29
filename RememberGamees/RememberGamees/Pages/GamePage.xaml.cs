﻿using RememberGamees.PageModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RememberGamees.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GamePage : ContentPage
    {
        IAuth auth;
        public GamePage()
        {
            InitializeComponent();
            BindingContext = new GamePageModel(Navigation);
            auth = DependencyService.Get<IAuth>();
        }
    }
}