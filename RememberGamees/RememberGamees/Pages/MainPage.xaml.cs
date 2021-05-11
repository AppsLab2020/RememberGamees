using Newtonsoft.Json;
using RememberGamees.PageModel;
using System;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static RememberGamees.Pages.LoginWithGmail;

namespace RememberGamees.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        IAuth auth;
        public MainPage()
        {
            InitializeComponent();
            auth = DependencyService.Get<IAuth>();
            BindingContext = new MainPageModel(Navigation, auth);
        }
    }
}