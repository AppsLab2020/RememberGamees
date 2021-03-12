using RememberGamees.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RememberGamees.PageModel
{
    class GamePageModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public GamePageModel(INavigation navigation)
        {
            this.Navigation = navigation;

            this.GameBtnCommand = new Command( () =>
            {
                Application.Current.MainPage = new ReactionGamePage01();
            });

        }

        //public async System.Threading.Tasks.Task GotoPage2Async()
        //{
        //    await Navigation.PushAsync(new ReactionGamePage01());
        //}

        
        public Command GameBtnCommand { get; }
        public INavigation Navigation { get; }

        protected virtual void OnPropertyChanges([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
