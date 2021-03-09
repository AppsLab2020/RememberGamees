using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;
using System.Timers;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using RememberGamees.Pages;
using System.Runtime.CompilerServices;

namespace RememberGamees.PageModel
{
    class ReactionGamePageModel01 : INotifyPropertyChanged
    {
        private readonly List<DateTime> tapTimes;
        private int _countSeconds = 60;
        public ImageSource DefaultImage = "Image1";
        public string DefaultTime = "";
        private static int i;
        public static int Fifty;
        public ImageSource DefaultBrainImage = "FirstBrainImage";
        public ImageSource SecondDefaultBrainImage = "SecondBrainImage";
        public ImageSource ThirdDefaultBrainImage = "ThirdBrainImage";

        List<string> images = new List<string> { "Image1", "Image2", "Image3", "Image4", "Image5", "Image6", "Image7", "Image8", "Image8", "Image9", "Image10" };

        public event PropertyChangedEventHandler PropertyChanged;


        public Command firstBtn_Clicked => new Command(() =>
        {
            var rand = new Random();
            var next = rand.Next(10);
            var image = images[next];

            RandomI = ImageSource.FromFile(image);

            Fifty = i + 50;
            i = Fifty;
            Experiences = Fifty.ToString();
        });

        public Command secondBtn_Clicked => new Command(() =>
        {
            var rand = new Random();
            var next = rand.Next(10);
            var image = images[next];

            RandomI = ImageSource.FromFile(image);

            tapTimes.Add(DateTime.Now);
            if (tapTimes.Count == 1)
            {
                FirstBrain = "Null";
            }

            else if (tapTimes.Count == 2)
            {
                SecondBrain = "Null";
            }

            else
            {
                ThirdBrain = "Null";
            }
        });

        public Command thirdBtn_Clicked => new Command(() =>
        {
            var rand = new Random();
            var next = rand.Next(10);
            var image = images[next];

            RandomI = ImageSource.FromFile(image);
        });

        public ImageSource ThirdBrain
        {
            get => ThirdDefaultBrainImage;
            set
            {
                ThirdDefaultBrainImage = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(ThirdBrain)));
            }
        }

        public ImageSource SecondBrain
        {
            get => SecondDefaultBrainImage;
            set
            {
                SecondDefaultBrainImage = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(SecondBrain)));
            }
        }

        public ImageSource FirstBrain
        {
            get => DefaultBrainImage;
            set
            {
                DefaultBrainImage = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(FirstBrain)));
            }
        }

        public string Experiences
        {
            get => DefaultTime;
            set
            {
                DefaultTime = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Experiences)));
            }
        }

        public string TimerTxt
        {
            get => DefaultTime;
            set
            {
                DefaultTime = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(TimerTxt)));
            }
        }

        public ImageSource RandomI
        {
            get => DefaultImage;
            set
            {
                DefaultImage = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(RandomI)));
            }
        }

        public INavigation Navigation { get; }
        public Command GameBtnCommand { get; }

        public ReactionGamePageModel01(INavigation navigation)
        {
            tapTimes = new List<DateTime>();

            this.Navigation = navigation;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                _countSeconds--;
                TimerTxt = _countSeconds.ToString();
                return Convert.ToBoolean(_countSeconds);
            });

            Device.StartTimer(TimeSpan.FromSeconds(10), () =>
            {
                Navigation.PushAsync(new ScoreReactionPage());

                Fifty = 0;
                i = Fifty;

                return false;
            });



        }
    }
}
