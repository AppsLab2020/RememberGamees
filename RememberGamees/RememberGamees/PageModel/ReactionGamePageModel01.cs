using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;
using System.Timers;


namespace RememberGamees.PageModel
{
    class ReactionGamePageModel01 
    {

        public Command firstBtn_Clicked => new Command(() =>
        {
        });

        public Command secondBtn_Clicked => new Command(() =>
        {

        });

        public Command thirdBtn_Clicked => new Command(() =>
        {
            
        });

        public object VariableImage { get; private set; }


        
        
       
        
        //popup method
        public static async void PopUp()
        {
            await App.Current.MainPage.DisplayAlert("Score", "You reached:(Score)", "OK");
        }

        //timer
        public void SecTimer()
        { 

        }
    }
}
