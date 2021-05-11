using Newtonsoft.Json;
using RememberGamees.PageModel;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static RememberGamees.Pages.LoginWithGmail;

namespace RememberGamees.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GamePage : ContentPage
    {

        IAuth auth;
        public GamePage()
        {
            InitializeComponent();
            BindingContext = new GamePageModel(Navigation);
            auth = DependencyService.Get<IAuth>();
        }
    }
}