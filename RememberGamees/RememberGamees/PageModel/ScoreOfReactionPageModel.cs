using Android;
using Android.OS;
using Android.Widget;

using RememberGamees.Pages;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Net;
using System.Text;
using Xamarin.Forms;

namespace RememberGamees.PageModel
{
    public class ScoreOfReactionPageModel
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
