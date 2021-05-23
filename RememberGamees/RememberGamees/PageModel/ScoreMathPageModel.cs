using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RememberGamees.PageModel
{
    public class ScoreMathPageModel
    {
        public ScoreMathPageModel(INavigation navigation)
        {
            RootButton = new Command(async () => await navigation.PopToRootAsync());
        }
        public INavigation navigation { get; set; }
        public Command RootButton { get; set; }
    }
}
