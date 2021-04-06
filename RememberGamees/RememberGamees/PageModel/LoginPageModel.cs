using RememberGamees.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RememberGamees.PageModel
{
    class LoginPageModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int DefaultChanging = 0;

        public LoginPageModel()
        {

            Button_Clicked = new Command(async () =>
            {
                Application.Current.MainPage = new GamePage();
            });

            
        }
        public Command Button_Clicked { get; }

        protected virtual void OnPropertyChanges([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
