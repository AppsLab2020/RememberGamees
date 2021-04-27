using RememberGamees.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RememberGamees.PageModel
{
    class ScoreOfMemoryPageModel
    {
        public ScoreOfMemoryPageModel(INavigation navigation)
        {
                    ScoreButton = new Command(async () => await navigation.PopToRootAsync());
        }
        public INavigation navigation { get; set; }
        public Command ScoreButton { get; set; }
    }
}
