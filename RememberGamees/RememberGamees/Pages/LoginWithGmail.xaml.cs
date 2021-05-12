using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RememberGamees.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginWithGmail : ContentPage
    {
        private string _name;
        public LoginWithGmail()
        {
            InitializeComponent();
            WebView.Source = "https://www.facebook.com/v7.0/dialog/oauth?client_id=850322265560226&response_type=token&redirect_uri=https://braingame-41f79.firebaseapp.com/__/auth/handler";
            WebView.Navigated += WebView_Navigated;
        }
        private void WebView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            var AccesURL = e.Url;
            if (AccesURL.Contains("access_token"))
            {
                AccesURL = AccesURL.Replace("https://braingame-41f79.firebaseapp.com/__/auth/handler?#access_token=", string.Empty);
                var accesstoken = AccesURL.Split('&')[0];
                HttpClient client = new HttpClient();
                var response = client.GetStringAsync("https://graph.facebook.com/me?fields=email,name,picture&access_token=" + accesstoken).Result;

                var Data = JsonConvert.DeserializeObject<FacebookProfile>(response);
                ImgPic.Source = Data.Picture.Data.Url;
                _name = Name.Text = Data.Name;
                Email.Text = Data.email;
            }

        }
        public void GamePageNav_Clicked(object sender, EventArgs e)
        {
            if(_name != null)
            {
                Navigation.PushAsync(new GamePage());
                Application.Current.Properties["IsLoggedIn"] = Boolean.TrueString;
            }
        }
        public class FacebookProfile
        {
            public string Name { get; set; }
            public Picture Picture { get; set; }
            public string email { get; set; }
        }
        public class Picture
        {
            public Data Data { get; set; }
        }
        public class Data
        {
            public bool IsSilhoutte { get; set; }
            public  string Url { get; set; }
        }
    }
}