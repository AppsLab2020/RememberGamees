using RememberGamees.Pages;
using Xamarin.Forms;

namespace RememberGamees.PageModel
{
    public class ScoreOfReactionPageModel
    {
        public ScoreOfReactionPageModel(INavigation navigation)        
        {
             SeeAchievements = new Command(async () => await navigation.PushAsync(new Achievements()));
             Button_Clicked = new Command(async () => await navigation.PopToRootAsync());
        }
            public INavigation navigation { get; set; }
            public Command Button_Clicked { get; set; }
            public Command SeeAchievements { get; set; }
    }
}
