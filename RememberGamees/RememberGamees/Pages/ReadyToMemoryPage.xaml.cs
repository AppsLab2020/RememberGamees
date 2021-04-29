using RememberGamees.PageModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RememberGamees.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReadyToMemoryPage : ContentPage
    {
        public ReadyToMemoryPage()
        {
            InitializeComponent();
            BindingContext = new ReadyToMemoryPageModel(Navigation);
        }
    }
}