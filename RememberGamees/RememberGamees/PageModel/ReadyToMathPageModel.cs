using RememberGamees.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RememberGamees.PageModel
{
    class ReadyToMathPageModel
    {
        public ReadyToMathPageModel(INavigation navigation)
        {
            ReadyToPlay_Clicked = new Command(async () => await navigation.PushAsync(new MathGamePage()));
        }

        public Command ReadyToPlay_Clicked { get; set; }
    }
}
