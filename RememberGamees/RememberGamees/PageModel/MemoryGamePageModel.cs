using Android.App;
using RememberGamees.Data;
using RememberGamees.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using Person = RememberGamees.Data.ExperienceOfPerson;

namespace RememberGamees.PageModel
{
    class MemoryGamePageModel : INotifyPropertyChanged
    {
        List<string> images = new List<string> { "Image1", "Image2", "Image3", "Image4"};
        private string _stringNewRandomImage;
        private string _stringOldRandomImage;
        private string _setExperience = "0";

        private ImageSource _firstImage = "Image1";

        private int _additionExperience;
        private int _fifty;

        public event PropertyChangedEventHandler PropertyChanged;

        public ImageSource RandomImage_Source
        {
            get => _firstImage;
            set
            {
                _firstImage = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(RandomImage_Source)));
            }
        }
        public string NewRandImageInLabel{get => _stringNewRandomImage;}

        public string OldRandImageInLabel{get => _stringOldRandomImage;}

        public string Experiences2_Text
        {
            get => _setExperience;
            set
            {
                _setExperience = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Experiences2_Text)));
            }
        }
        public Command Yes_Clicked { get; set; }
        public Command No_Clicked { get; set; }

        public MemoryGamePageModel(INavigation navigation)
        {
            DisplayRandomImage();
            Yes_Clicked = new Command(async () =>
            {
                if (OldRandImageInLabel == NewRandImageInLabel || _stringNewRandomImage == _firstImage.ToString())
                {
                    _fifty = _additionExperience + 50;
                    _additionExperience = _fifty;
                    Experiences2_Text = _additionExperience.ToString();
                }
                else
                {
                    await App.Database.SavePersonAsync(new Person
                    {
                        Results = int.Parse(Experiences2_Text)
                    });

                    await navigation.PushAsync(new ScoreOfMemoryGamePage());

                }

                _stringOldRandomImage = _stringNewRandomImage;
                CreateRandomImage();
            });

            No_Clicked = new Command(async () =>
            {
            if (OldRandImageInLabel != NewRandImageInLabel)
            {
                    _fifty = _additionExperience + 50;
                    _additionExperience = _fifty;
                    Experiences2_Text = _additionExperience.ToString();
            }
            else
            {
                await App.Database.SavePersonAsync(new Person
                {
                    Results = int.Parse(Experiences2_Text)
                });

                await navigation.PushAsync(new ScoreOfMemoryGamePage());
            }

            _stringOldRandomImage = _stringNewRandomImage;
            CreateRandomImage();
            });

        }
        private void DisplayRandomImage()
        {
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                CreateRandomImage();
                return false;
            });
        }
        private void CreateRandomImage()
        {
            var rand = new Random();
            var next = rand.Next(4);
            _stringNewRandomImage = images[next];
            RandomImage_Source = ImageSource.FromFile(_stringNewRandomImage);
        }
    }
}
