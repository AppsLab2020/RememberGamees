using RememberGamees.Data;
using RememberGamees.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace RememberGamees.PageModel
{
    class MemoryGamePageModel : INotifyPropertyChanged
    {
        List<string> images = new List<string> { "Image1", "Image2", "Image3", "Image4"};
        private bool _nextPage = false;
        private readonly List<DateTime> tapTimes;
        private string _stringNewRandomImage;
        private string _stringOldRandomImage;
        private int _setExperience;

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
        private int _countSeconds = 75;

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

        public int Experiences2_Text
        {
            get => _setExperience;
            set
            {
                _setExperience = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Experiences2_Text)));
            }
        }

        public int Time_Text
        {
            get => _countSeconds;
            set
            {
                _countSeconds = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Time_Text)));
            }
        }
        public Command Yes_Clicked { get; set; }
        public Command No_Clicked { get; set; }

        public MemoryGamePageModel(INavigation navigation)
        {
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                Time_Text--;
                return Convert.ToBoolean(_countSeconds);
            });
            Device.StartTimer(TimeSpan.FromSeconds(75), () =>
            {
                if (!_nextPage)
                {
                    Navigate(navigation);

                    Experiences2_Text = 0;
                    _brainsDeletes = 0;
                    _setExperience = 0;
                }
                return false;
            });

            tapTimes = new List<DateTime>();

            DisplayRandomImage();

            Yes_Clicked = new Command(async () =>
            {
                tapTimes.Add(DateTime.Now);
                if (_stringOldRandomImage == _stringNewRandomImage || _stringNewRandomImage == "Image1" && tapTimes.Count == 1)
                {
                    _fifty = _additionExperience + 50;
                    _additionExperience = _fifty;
                    Experiences2_Text = _additionExperience;
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
                        if(!_nextPage)
                        {
                            _brainsDeletes = 0;
                            _countOfBrainDeletes = _brainsDeletes;

                            await App.Database.SaveScoreOfMemoryAsync(new ScoreOfMemory
                            {
                                MemoryScore = Experiences2_Text
                            });
                            _nextPage = true;
                            await navigation.PushAsync(new ScoreOfMemoryGamePage(Experiences2_Text));
                        }
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
                    Experiences2_Text = _additionExperience;
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
                    if (!_nextPage)
                        {
                            _brainsDeletes = 0;
                            _countOfBrainDeletes = _brainsDeletes;

                            await App.Database.SaveScoreOfMemoryAsync(new ScoreOfMemory
                            {
                                MemoryScore = Experiences2_Text
                            });

                            await navigation.PushAsync(new ScoreOfMemoryGamePage(Experiences2_Text));
                            _nextPage = true;
                        }
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
        public void CreateRandomImage()
        {
            var rand = new Random();
            var next = rand.Next(4);
            _stringNewRandomImage = images[next];
            RandomImage_Source = ImageSource.FromFile(_stringNewRandomImage);
        }
        private async void Navigate(INavigation navigation)
        {
            if (!string.IsNullOrWhiteSpace(Experiences2_Text.ToString()))
            {
                await App.Database.SaveScoreOfMemoryAsync(new ScoreOfMemory
                {
                    MemoryScore = Experiences2_Text
                });
            }
            await navigation.PushAsync(new ScoreMathPage(Experiences2_Text));
            _nextPage = true;
        }
    }
}
