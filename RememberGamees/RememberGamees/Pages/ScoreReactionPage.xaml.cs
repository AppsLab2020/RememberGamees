using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Person = RememberGamees.Data.ExperienceOfPerson;
using System.ComponentModel;
using RememberGamees.PageModel;

namespace RememberGamees.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScoreReactionPage : INotifyPropertyChanged 
    {

        public ScoreReactionPage(string expParameter)
        {
            InitializeComponent();
            BindingContext = new ScoreOfReactionPageModel(Navigation);
            userExperience.Text = "Your score: " + expParameter;



            Shell.SetTabBarIsVisible(this, false);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetPeopleAsync();
        }
    }
}