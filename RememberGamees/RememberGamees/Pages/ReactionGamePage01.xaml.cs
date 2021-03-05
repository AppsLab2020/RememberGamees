using RememberGamees.PageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RememberGamees.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReactionGamePage01 : ContentPage
    {
        public ReactionGamePage01()
        {
            InitializeComponent();
            BindingContext = new ReactionGamePageModel01();
            Shell.SetTabBarIsVisible(this, false); 
        }

    }
}