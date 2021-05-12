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
    public partial class MemoryChartPage : ContentPage
    {
        public MemoryChartPage()
        {
            InitializeComponent();
            BindingContext = new MemoryChartPageModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //ChartData = await App.Database.GetScoreOfMemoryAsync();
            await (BindingContext as MemoryChartPageModel).GetScoreOfMemoryAsync();
        }
    }
}