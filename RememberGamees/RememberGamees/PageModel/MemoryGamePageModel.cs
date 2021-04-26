using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace RememberGamees.PageModel
{
    class MemoryGamePageModel : INotifyPropertyChanged
    {
        private ImageSource firstImage = "Image1";
        private ImageSource secondImage = "Image2";
        private ImageSource thirdImage = "Image3";
        private ImageSource fourthImage = "Image4";
        private ImageSource fivethImage = "Image5";
        private ImageSource sixthImage = "Image6";

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

        });

        public Command No_Clicked => new Command(async () =>
        {

        });

        public MemoryGamePageModel()
        {

        }
    }
}
