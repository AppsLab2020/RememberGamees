using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;
using System.Timers;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;

namespace RememberGamees.PageModel
{
    class ReactionGamePageModel01 : INotifyPropertyChanged
    {
        private int _countSeconds = 60;
        public ImageSource DefaultImage = "Image1";
        public string DefaultTime = "";

        List<string> images = new List<string> { "Image1", "Image2", "Image3", "Image4", "Image5", "Image6", "Image7", "Image8", "Image8", "Image9", "Image10" };

        public event PropertyChangedEventHandler PropertyChanged;


        public Command firstBtn_Clicked => new Command(() =>
        {
            var rand = new Random();
            var next = rand.Next(10);
            var image = images[next];

            RandomI = ImageSource.FromFile(image);
        });

        public Command secondBtn_Clicked => new Command(() =>
        {
            var rand = new Random();
            var next = rand.Next(10);
            var image = images[next];

            RandomI = ImageSource.FromFile(image);
        });

        public Command thirdBtn_Clicked => new Command(() =>
        {
            var rand = new Random();
            var next = rand.Next(10);
            var image = images[next];

            RandomI = ImageSource.FromFile(image);
        });

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

        public ReactionGamePageModel01()
        {
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                _countSeconds--;
                TimerTxt = _countSeconds.ToString();
                return Convert.ToBoolean(_countSeconds);
            });
        }
    }
}
