using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Person = RememberGamees.Data.ExperienceOfPerson;
using System.ComponentModel;

namespace RememberGamees.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScoreReactionPage : INotifyPropertyChanged 
    {

        public ScoreReactionPage(string expParameter)
        {
            InitializeComponent();
            //BindingContext = new ScoreOfReactionPageModel();
            userExperience.Text = expParameter;



            Shell.SetTabBarIsVisible(this, false);
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(userExperience.Text))
            {
                await App.Database.SavePersonAsync(new Person
                {
                    Results = int.Parse(userExperience.Text)
                });

                nameEntry.Text = resultsEntry.Text = string.Empty;
                collectionView.ItemsSource = await App.Database.GetPeopleAsync();
            }
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetPeopleAsync();
        }
    }
}