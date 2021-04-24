using RememberGamees.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RememberGamees.PageModel
{
    class GamePageModel
    {

        public GamePageModel(INavigation navigation)
        {
            this.Navigation = navigation;
            this.GameBtnCommand = new Command(async () => await Navigation.PushAsync(new ReactionGamePage01()));
        }

        public INavigation Navigation { get; set; }
        public Command GameBtnCommand { get; set; }
    }
}
