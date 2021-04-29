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
        private ImageSource _defaultBrainImage = "FirstBrainImage";
        private ImageSource _secondDefaultBrainImage = "SecondBrainImage";
        private ImageSource _thirdDefaultBrainImage = "ThirdBrainImage";
        private ImageSource _fourthDefaultBrainImage = "FourthBrainImage";
        private ImageSource _fifthDefaultBrainImage = "FifthBrainImage";

        private int _additionExperience;
        private int _fifty;
        private int _countOfBrainDeletes;
        private int _brainsDeletes = 0;

        public event PropertyChangedEventHandler PropertyChanged;

        public ImageSource FirstBrainImage_Source
        {
            get => _defaultBrainImage;
            set
            {
                _defaultBrainImage = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(FirstBrainImage_Source)));
            }
        }

        public ImageSource SecondBrainImage_Source
        {
            get => _secondDefaultBrainImage;
            set
            {
                _secondDefaultBrainImage = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(SecondBrainImage_Source)));
            }
        }
        public ImageSource ThirdBrainImage_Source
        {
            get => _thirdDefaultBrainImage;
            set
            {
                _thirdDefaultBrainImage = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(ThirdBrainImage_Source)));
            }
        }
        public ImageSource FourthBrainImage_Source
        {
            get => _fourthDefaultBrainImage;
            set
            {
                _fourthDefaultBrainImage = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(FourthBrainImage_Source)));
            }
        }
        public ImageSource FifthBrainImage_Source
        {
            get => _fifthDefaultBrainImage;
        }

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
                if (_stringOldRandomImage == _stringNewRandomImage || _stringNewRandomImage == "Image1")
                {
                    _fifty = _additionExperience + 50;
                    _additionExperience = _fifty;
                    Experiences2_Text = _additionExperience.ToString();
                }
                else
                {
                    _brainsDeletes = _countOfBrainDeletes + 1;
                    _countOfBrainDeletes = _brainsDeletes;
                    if (_brainsDeletes == 0)
                    { }
                    else if (_brainsDeletes == 1)
                    {
                        FirstBrainImage_Source = "Null";
                    }
                    else if (_brainsDeletes == 2)
                    {
                        SecondBrainImage_Source = "Null";
                    }
                    else if (_brainsDeletes == 3)
                    {
                        ThirdBrainImage_Source = "Null";
                    }
                    else if (_brainsDeletes == 4)
                    {
                        FourthBrainImage_Source = "Null";
                    }
                    else
                    {
                        _brainsDeletes = 0;
                        _countOfBrainDeletes = _brainsDeletes;

                        await App.Database.SavePersonAsync(new Person
                        {
                            Results = int.Parse(Experiences2_Text)
                        });

                        await navigation.PushAsync(new ScoreOfMemoryGamePage());
                    }
                }

                _stringOldRandomImage = _stringNewRandomImage;
                CreateRandomImage();
            });

            No_Clicked = new Command(async () =>
            {
            if (_stringOldRandomImage != _stringNewRandomImage)
            {
                    _fifty = _additionExperience + 50;
                    _additionExperience = _fifty;
                    Experiences2_Text = _additionExperience.ToString();
            }
            else
            {
                    _brainsDeletes = _countOfBrainDeletes + 1;
                    _countOfBrainDeletes = _brainsDeletes;
                    if (_brainsDeletes == 0)
                    { }
                    else if (_brainsDeletes == 1)
                    {
                        FirstBrainImage_Source = "Null";
                    }
                    else if (_brainsDeletes == 2)
                    {
                        SecondBrainImage_Source = "Null";
                    }
                    else if (_brainsDeletes == 3)
                    {
                        ThirdBrainImage_Source = "Null";
                    }
                    else if (_brainsDeletes == 4)
                    {
                        FourthBrainImage_Source = "Null";
                    }
                    else
                    {
                        _brainsDeletes = 0;
                        _countOfBrainDeletes = _brainsDeletes;

                        await App.Database.SavePersonAsync(new Person
                        {
                            Results = int.Parse(Experiences2_Text)
                        });

                        await navigation.PushAsync(new ScoreOfMemoryGamePage());
                    }
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
