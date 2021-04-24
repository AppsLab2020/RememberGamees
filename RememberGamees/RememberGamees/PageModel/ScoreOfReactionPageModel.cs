using RememberGamees.Pages;
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
