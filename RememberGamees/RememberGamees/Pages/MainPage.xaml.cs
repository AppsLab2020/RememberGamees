using RememberGamees.PageModel;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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

        private void LoginFb_Clicked(object sender, EventArgs e)
        {

            WebView.Source = "https://www.facebook.com/login.php?skip_api_login=1&api_key=796421244349941&kid_directed_site=0&app_id=796421244349941&signed_next=1&next=https%3A%2F%2Fwww.facebook.com%2Fv7.0%2Fdialog%2Foauth%3Fclient_id%3D796421244349941%26response_type%3Dtoken%26redirest_uri%3Dhttps%253A%252F%252Fbraingame-41f79.firebaseapp.com%252F__%252Fauth%252Fhandler%26ret%3Dlogin%26fbapp_pres%3D0%26logger_id%3D0f7e9732-4d5c-482b-bb3f-d76c40d17c67%26tp%3Dunspecified&cancel_url=%3Ferror%3Daccess_denied%26error_code%3D200%26error_description%3DPermissions%2Berror%26error_reason%3Duser_denied%23_%3D_&display=page&locale=sk_SK&pl_dbl=0";
            WebView.Navigated += WebView_Navigated;
        }

        private void WebView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            var AccesURL = e.Url;
        }
    }
}