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
        private ImageSource DefaultImage = "Image1";
        private string DefaultTime = "";
        private static int b;
        private static int i;
        private static int fifty;
        private ImageSource DefaultBrainImage = "FirstBrainImage";
        private ImageSource SecondDefaultBrainImage = "SecondBrainImage";
        private ImageSource ThirdDefaultBrainImage = "ThirdBrainImage";
        private ImageSource FourthDefaultBrainImage = "FourthBrainImage";
        private ImageSource FifthDefaultBrainImage = "FifthBrainImage";
        private ImageSource FirstImage = "Image1";
        private ImageSource SecondImage = "Image2";
        private ImageSource ThirdImage = "Image3";
        private ImageSource FourthImage = "Image4";
        private ImageSource FivethImage = "Image5";
        private ImageSource SixthImage = "Image6";
        private ImageSource SeventhImage = "Image7";
        private ImageSource EighthImage = "Image8";
        private ImageSource NinethImage = "Image9";
        private bool NextPage = false;
        private int BrainsDeletes = 0;

        List<string> images = new List<string> { "Image1", "Image2", "Image3", "Image4", "Image5", "Image6", "Image7", "Image8", "Image8", "Image9" };

        public event PropertyChangedEventHandler PropertyChanged;


        public Command firstBtn_Clicked => new Command(() =>
        {           
            tapTimes.Add(DateTime.Now);
            if (tapTimes.Count == 1)
            {
                fifty = i + 50;
                i = fifty;
                Experiences = fifty.ToString();
            }
            else if (randomImage == "Image1" || randomImage == "Image6" || randomImage == "Image8")
            {
                fifty = i + 50;
                i = fifty;
                Experiences = fifty.ToString();
            }
            else if (randomImage == "Image2" || randomImage == "Image3" || randomImage == "Image4" || randomImage == "Image5" || randomImage == "Image7" || randomImage == "Image9")
            {
                BrainsDeletes = b + 1;
                b = BrainsDeletes;
            }
            else
            {
                fifty = 0;
                i = fifty;

                BrainsDeletes = 0;
                b = BrainsDeletes;
                NextPage = true;
                Application.Current.MainPage = new ScoreReactionPage();
            }

            if(BrainsDeletes == 0)
            {

            }
            else if (BrainsDeletes == 1)
            {
                FirstBrain = "Null";
            }
            else if (BrainsDeletes == 2)
            {
                SecondBrain = "Null";
            }
            else if (BrainsDeletes == 3)
            {
                ThirdBrain = "Null";
            }
            else if (BrainsDeletes == 4)
            {
                FourthBrain = "Null";
            }
            else
            {
                fifty = 0;
                i = fifty;

                BrainsDeletes = 0;
                b = BrainsDeletes;

                //FifthBrain = "Null";
                NextPage = true;
                Application.Current.MainPage = new ScoreReactionPage();
            }

            CreateRandomImage();
        });

        public Command secondBtn_Clicked => new Command(() =>
        {

            RandomI = ImageSource.FromFile(randomImage);
            

            tapTimes.Add(DateTime.Now);
            if (tapTimes.Count == 1)
            {
                FirstBrain = "Null";
            }

            else if (tapTimes.Count == 2)
            {
                SecondBrain = "Null";
            }

            else if (tapTimes.Count == 3)
            {
                ThirdBrain = "Null";
            }

            else if (tapTimes.Count == 4)
            {
                FourthBrain = "Null";
            }

            else
            {
                fifty = 0;
                i = fifty;

                //FifthBrain = "Null";
                NextPage = true;
                Application.Current.MainPage = new ScoreReactionPage();
                
            }
        });

        public Command thirdBtn_Clicked => new Command(() =>
        {
            var rand = new Random();
            var next = rand.Next(10);
            var image = images[next];

            RandomI = ImageSource.FromFile(image);

            fifty = i + 50;
            i = fifty;
            Experiences = fifty.ToString();
        });

        public ImageSource FifthBrain
        {
            get => FifthDefaultBrainImage;
            set
            {
                FifthDefaultBrainImage = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(FifthBrain)));
            }
        }
           

        public ImageSource FourthBrain
        {
            get => FourthDefaultBrainImage;
            set
            {
                FourthDefaultBrainImage = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(FourthBrain)));
            }
        }

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
        public object FirstBtn { get; private set; }

        public ReactionGamePageModel01()
        {
            tapTimes = new List<DateTime>();

            
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                _countSeconds--;
                TimerTxt = _countSeconds.ToString();
                return Convert.ToBoolean(_countSeconds);
            });

            Device.StartTimer(TimeSpan.FromSeconds(60), () =>
            {
                if (!NextPage)
                {
                    Application.Current.MainPage = new ScoreReactionPage();
                    fifty = 0;
                    i = fifty;
                }
                return false;
            });

            CreateRandomImage();
        }

        private string randomImage;

        private void CreateRandomImage()
        {
            var rand = new Random();
            var next = rand.Next(10);
            randomImage = images[next];

            RandomI = ImageSource.FromFile(randomImage);
        }
}   }
