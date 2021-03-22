using RememberGamees.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace RememberGamees.PageModel
{
    class ScoreOfReactionPageModel
    {
        public ScoreOfReactionPageModel()
        {

        }
        public Command Button_Clicked => new Command(() =>
        {
            Application.Current.MainPage = new GamePage();
        });
    }
}
