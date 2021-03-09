using RememberGamees.PageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RememberGamees.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScoreReactionPage : ContentPage
    {
        public ScoreReactionPage()
        {
            InitializeComponent();
            BindingContext = new ScoreOfReactionPageModel(Navigation);
            Shell.SetTabBarIsVisible(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Navigation.RemovePage(this.Navigation.NavigationStack[this.Navigation.NavigationStack.Count - 2]);

            this.Navigation.PopAsync();
        }
    }
}