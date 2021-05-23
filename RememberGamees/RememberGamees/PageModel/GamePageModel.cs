using Newtonsoft.Json;
using RememberGamees.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using static RememberGamees.Pages.LoginWithGmail;

namespace RememberGamees.PageModel
{
    class GamePageModel
    {

        public GamePageModel(INavigation navigation)
        {
            Navigation = navigation;
            GameBtnCommand = new Command(async () => await Navigation.PushAsync(new ReadyToReactionPage()));
            SignOutButton_Clicked = new Command(async () =>
            {
                await Navigation.PushAsync(new MainPage());
                Application.Current.Properties["IsLoggedIn"] = Boolean.FalseString;
            });
            MemoryGame_Clicked = new Command(async () => await Navigation.PushAsync(new ReadyToMemoryPage()));
            LogicalGame_Clicked = new Command(async () => await Navigation.PushAsync(new LogicalGamePage()));
            MathGame_Clicked = new Command(async () => await Navigation.PushAsync(new ReadyToMathPage()));
            MemoryChart_Clicked = new Command(async () => await Navigation.PushAsync(new MemoryChartPage()));
            ReactionChart_Clicked = new Command(async () => await Navigation.PushAsync(new ReactionChartPage()));
            MathChart_Clicked = new Command(async () => await Navigation.PushAsync(new MathChartPage()));
        }
        public INavigation Navigation { get; set; }
        public Command GameBtnCommand { get; set; }
        public Command SignOutButton_Clicked { get; set; }
        public Command MemoryGame_Clicked { get; set; }
        public Command LogicalGame_Clicked { get; set; }
        public Command MathGame_Clicked { get; set; }
        public Command MemoryChart_Clicked { get; set; }
        public Command ReactionChart_Clicked { get; set; }
        public Command MathChart_Clicked { get; set; }
    }
}
