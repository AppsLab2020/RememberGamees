using RememberGamees.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace RememberGamees.PageModel
{
    public class MainPageModel : INotifyPropertyChanged
    {

        private string _emailString;
        private string _passwordString;

        public event PropertyChangedEventHandler PropertyChanged;

        public string EmailInput
        {
            get => _emailString;
            set
            {
                _emailString = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(EmailInput)));
            }
        }

        public string PasswordInput
        {
            get => _passwordString;
            set
            {
                _passwordString = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(PasswordInput)));
            }
        }
        IAuth auth;
        public MainPageModel(INavigation navigation, IAuth auth)
        {
            auth = DependencyService.Get<IAuth>();
            SignUpClicked = new Command(async () =>
            {
                var signOut = auth.SignOut();

                if (signOut)
                {
                    await navigation.PushAsync(new SignUpPage());
                }
            });

            LoginClicked = new Command(async () =>
            {
                string token = await auth.LoginWithEmailAndPassword(EmailInput, PasswordInput);

                if (token != string.Empty)
                {
                    await Application.Current.MainPage.DisplayAlert("Authentication Successed", "Welcome in BrainGame", "Ok");
                    await navigation.PushAsync(new GamePage());
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Authentication Failed", "Email or Password are incorrect", "Ok");
                }
            });
        }
        public Command SignUpClicked { get; set; }
        public Command LoginClicked { get; set; }
        public INavigation navigation { get; set; }
    }
}
