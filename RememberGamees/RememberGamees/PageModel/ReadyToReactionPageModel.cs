using RememberGamees.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RememberGamees.PageModel
{
    class ReadyToReactionPageModel
    {
        public ReadyToReactionPageModel(INavigation navigation)
        {
            GoToPlay_Command = new Command(async () => await navigation.PushAsync(new ReactionGamePage01()));
        }
        public INavigation navigation { get; set; }
        public Command GoToPlay_Command { get; set; }
    }
}
