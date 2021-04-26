using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace RememberGamees.PageModel
{
    class MemoryGamePageModel : INotifyPropertyChanged
    {
        List<string> images = new List<string> { "Image1", "Image2", "Image3", "Image4", "Image5", "Image6", "Image7", "Image8", "Image8", "Image9" };
        private string randomImage;

        private ImageSource firstImage = "Image1";
        private ImageSource secondImage = "Image2";
        private ImageSource thirdImage = "Image3";
        private ImageSource fourthImage = "Image4";
        private ImageSource fivethImage = "Image5";
        private ImageSource sixthImage = "Image6";
        private ImageSource oldImage;

        private int AdditionExperience;
        private int fifty;

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

        public Command Yes_Clicked => new Command(async () =>
        {
            CreateRandomImage();
        });

        public Command No_Clicked => new Command(async () =>
        {
            CreateRandomImage();
        });

        public MemoryGamePageModel()
        {

        }
        private void CreateRandomImage()
        {
            var rand = new Random();
            var next = rand.Next(9);
            randomImage = images[next];
            RandomI = ImageSource.FromFile(randomImage);
        }
    }
}
