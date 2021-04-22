using Android.App;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RememberGamees.Data;
using Person = RememberGamees.Data.Person;

namespace RememberGamees.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScoreReactionPage : ContentPage
    {

        public ScoreReactionPage()
        {
            InitializeComponent();
            //BindingContext = new ScoreOfReactionPageModel();
            Shell.SetTabBarIsVisible(this, false);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetPeopleAsync();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameEntry.Text) && !string.IsNullOrWhiteSpace(experiencesEntry.Text))
            {
                await App.Database.SavePersonAsync(new Person
                {
                    Name = nameEntry.Text,
                    Experiences = int.Parse(experiencesEntry.Text)
                });

                nameEntry.Text = experiencesEntry.Text = string.Empty;
                collectionView.ItemsSource = await App.Database.GetPeopleAsync();
            }
        }
    }
}