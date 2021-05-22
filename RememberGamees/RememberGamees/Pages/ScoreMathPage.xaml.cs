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
    public partial class ScoreMathPage : ContentPage
    {
        public ScoreMathPage(int exParameter)
        {
            InitializeComponent();
            userExperience.Text = "Your score: " + exParameter;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetScoreOfMathAsync();
        }
    }
}