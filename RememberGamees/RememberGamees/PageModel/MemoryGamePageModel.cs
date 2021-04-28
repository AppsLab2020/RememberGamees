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
        private string randomImage;
        private string newRandomImage { get; set; }

        private ImageSource firstImage = "Image1";
        private ImageSource secondImage = "Image2";
        private ImageSource thirdImage = "Image3";
        private ImageSource fourthImage = "Image4";

        private int AdditionExperience;
        private int fifty;

        private string setExperience;

        public event PropertyChangedEventHandler PropertyChanged;

        public ImageSource RandomI
        {
            get => firstImage;
            set
            {
                firstImage = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(RandomI)));
            }
        }
        public string randNumb
        {
            get => randomImage;
            set
            {
                firstImage = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(randNumb)));
            }
        }

        public string NewestRandNumb
        {
            get => newRandomImage;
            set
            {
                firstImage = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(NewestRandNumb)));
            }
        }

        public string Experiences2
        {
            get => setExperience;
            set
            {
                setExperience = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Experiences2)));
            }
        }
        public Command Yes_Clicked { get; set; }
        public Command No_Clicked { get; set; }

        public MemoryGamePageModel(INavigation navigation)
        {
            DisplayRandomImage();
            Yes_Clicked = new Command(async () =>
            {
                if (NewestRandNumb == randNumb || randomImage == firstImage.ToString())
                {
                    fifty = AdditionExperience + 50;
                    AdditionExperience = fifty;
                    Experiences2 = AdditionExperience.ToString();
                }
                else
                {
                    await App.Database.SavePersonAsync(new Person
                    {
                        Results = int.Parse(Experiences2)
                    });

                    await navigation.PushAsync(new ScoreOfMemoryGamePage());

                }

                newRandomImage = randomImage;
                CreateRandomImage();
            });

            No_Clicked = new Command(async () =>
            {
            if (NewestRandNumb != randNumb)
            {
                fifty = AdditionExperience + 50;
                AdditionExperience = fifty;
                Experiences2 = AdditionExperience.ToString();
            }
            else
            {
                await App.Database.SavePersonAsync(new Person
                {
                    Results = int.Parse(Experiences2)
                });

                await navigation.PushAsync(new ScoreOfMemoryGamePage());
            }

            newRandomImage = randomImage;
            CreateRandomImage();
            });

        }
        private void DisplayRandomImage()
        {
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                var rand = new Random();
                var next = rand.Next(4);
                randomImage = images[next];
                RandomI = ImageSource.FromFile(randomImage);
                return false;
            });
        }
        private void CreateRandomImage()
        {
            var rand = new Random();
            var next = rand.Next(4);
            randomImage = images[next];
            RandomI = ImageSource.FromFile(randomImage);
        }
    }
}
