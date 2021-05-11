using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RememberGamees.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginWithGmail : ContentPage
    {
        public LoginWithGmail()
        {
            InitializeComponent();
        }
        private void LoginFb_Clicked(object sender, EventArgs e)
        {

            WebView.Source = "https://www.facebook.com/v7.0/dialog/oauth?client_id=222448232546178&response_type=token&redirect_uri=https://braingame-41f79.firebaseapp.com/__/auth/handler";
            WebView.Navigated += WebView_Navigated;
        }
        private void WebView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            var AccesURL = e.Url;
        }
    }
}