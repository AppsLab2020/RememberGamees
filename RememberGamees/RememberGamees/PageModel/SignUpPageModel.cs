using RememberGamees.Pages;
using System.ComponentModel;
using Xamarin.Forms;

namespace RememberGamees.PageModel
{
    public class SignUpPageModel : INotifyPropertyChanged
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

        public SignUpPageModel(INavigation navigation, IAuth auth)
        {

            auth = DependencyService.Get<IAuth>();
            SignUpClicked = new Command(async () =>
            {
                var user = auth.SignUpWithEmailAndPassword(EmailInput, PasswordInput);

                if (user != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Success", "New User Created", "Ok");

                    var signOut = auth.SignOut();

                    if (signOut)
                    {
                        await navigation.PushAsync(new MainPage());
                    }
                    else
                    {
                        await Application.Current.MainPage.DisplayAlert("ERROR", "Something went wrong, please try again", "Ok");
                    }
                }
            });
        }
        public Command SignUpClicked { get; set; }
        public Command LoginClicked { get; set; }
        public INavigation navigation { get; set; }
        
    }
}
