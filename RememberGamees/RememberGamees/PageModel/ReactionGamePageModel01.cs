using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.ComponentModel;
using RememberGamees.Pages;
using System.Threading.Tasks;
using RememberGamees.Data;

namespace RememberGamees.PageModel
{
    class ReactionGamePageModel01 : INotifyPropertyChanged
    {
        List<string> images = new List<string> { "Image1", "Image2", "Image3", "Image4", "Image5", "Image6", "Image7", "Image8", "Image8", "Image9" };
        private string _defaultTime = "";
        private string _randomImage;
        private string _setExperience;
        private bool _nextPage = false;

        private int _countSeconds = 75;
        private int _countOfBrainDeletes;
        private int _brainsDeletes = 0;
        private int _additionExperience;
        private int _fifty;

        private ImageSource _defaultBrainImage = "FirstBrainImage";
        private ImageSource _secondDefaultBrainImage = "SecondBrainImage";
        private ImageSource _thirdDefaultBrainImage = "ThirdBrainImage";
        private ImageSource _fourthDefaultBrainImage = "FourthBrainImage";
        private ImageSource _fifthDefaultBrainImage = "FifthBrainImage";
        private ImageSource _firstImage = "Image1";
        public INavigation Navigation { get; set; }

        public ImageSource FifthBrainImage_Source
        {
            get => _fifthDefaultBrainImage;
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

        public string Experiences_Text
        {
            get => _setExperience;
            set
            {
                _setExperience = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Experiences_Text)));
            }
        }
        
        public string Timer_Text
        {
            get => _defaultTime;
            set
            {
                _defaultTime = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Timer_Text)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Command firstBtn_Clicked => new Command(async () =>
        {           
            if (_randomImage == "Image1" || _randomImage == "Image6" || _randomImage == "Image8")
            {
                _fifty = _additionExperience + 50;
                _additionExperience = _fifty;
                Experiences_Text = _fifty.ToString();
            }
            else if (_randomImage == "Image2" || _randomImage == "Image3" || _randomImage == "Image4" || _randomImage == "Image5" || _randomImage == "Image7" || _randomImage == "Image9")
            {
                _brainsDeletes = _countOfBrainDeletes + 1;
                _countOfBrainDeletes = _brainsDeletes;
            }
            else
            {
                _fifty = 0;
                _additionExperience = _fifty;

                _brainsDeletes = 0;
                _countOfBrainDeletes = _brainsDeletes;
                _nextPage = true;
                await Navigation.PushAsync(new ScoreReactionPage(Experiences_Text));

                if (!string.IsNullOrWhiteSpace(Experiences_Text))
                {
                    await App.Database.SaveScoreOfReactionAsync(new ScoreOfReaction
                    {
                        ReactionScore = int.Parse(Experiences_Text)
                    });
                }
            }

            if(_brainsDeletes == 0)
            {}
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
                _fifty = 0;
                _additionExperience = _fifty;

                _brainsDeletes = 0;
                _countOfBrainDeletes = _brainsDeletes;

                _nextPage = true;
                await Navigation.PushAsync(new ScoreReactionPage(Experiences_Text));

                if (!string.IsNullOrWhiteSpace(Experiences_Text))
                {
                    await App.Database.SaveScoreOfReactionAsync(new ScoreOfReaction
                    {
                        ReactionScore = int.Parse(Experiences_Text)
                    });
                }
            }

            CreateRandomImage();
        });

        public Command secondBtn_Clicked => new Command(async () =>
        {           
            if (_randomImage == "Image3" || _randomImage == "Image5" || _randomImage == "Image7")
            {
                _fifty = _additionExperience + 50;
                _additionExperience = _fifty;
                Experiences_Text = _fifty.ToString();
            }
            else if (_randomImage == "Image1" || _randomImage == "Image2" || _randomImage == "Image4" || _randomImage == "Image6" || _randomImage == "Image8" || _randomImage == "Image9")
            {
                _brainsDeletes = _countOfBrainDeletes + 1;
                _countOfBrainDeletes = _brainsDeletes;
            }
            else
            {
                //_fifty = 0;
                //_additionExperience = _fifty;

                //_brainsDeletes = 0;
                //_countOfBrainDeletes = _brainsDeletes;
                //_nextPage = true;
                //await Navigation.PushAsync(new ScoreReactionPage(Experiences_Text));

                //if (!string.IsNullOrWhiteSpace(Experiences_Text))
                //{
                //    await App.Database.SaveScoreOfReactionAsync(new ScoreOfReaction
                //    {
                //        ReactionScore = int.Parse(Experiences_Text)
                //    });
                //}
            }

            if (_brainsDeletes == 0)
            {}
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
                //_fifty = 0;
                //_additionExperience = _fifty;

                //_brainsDeletes = 0;
                //_countOfBrainDeletes = _brainsDeletes;

                //_nextPage = true;
                //await Navigation.PushAsync(new ScoreReactionPage(Experiences_Text));

                //if (!string.IsNullOrWhiteSpace(Experiences_Text))
                //{
                //    await App.Database.SaveScoreOfReactionAsync(new ScoreOfReaction
                //    {
                //        ReactionScore = int.Parse(Experiences_Text)
                //    });
                //}
            }
            CreateRandomImage();
        });

        public Command thirdBtn_Clicked => new Command(async () =>
        {
            if (_randomImage == "Image2" || _randomImage == "Image4" || _randomImage == "Image9")
            {
                _fifty = _additionExperience + 50;
                _additionExperience = _fifty;
                Experiences_Text = _fifty.ToString();
            }
            else if (_randomImage == "Image1" || _randomImage == "Image3" || _randomImage == "Image5" || _randomImage == "Image6" || _randomImage == "Image7" || _randomImage == "Image8")
            {
                _brainsDeletes = _countOfBrainDeletes + 1;
                _countOfBrainDeletes = _brainsDeletes;
            }
            else
            {
                //_fifty = 0;
                //_additionExperience = _fifty;

                //_brainsDeletes = 0;
                //_countOfBrainDeletes = _brainsDeletes;
                //_nextPage = true;
                //await Navigation.PushAsync(new ScoreReactionPage(Experiences_Text));

                //if (!string.IsNullOrWhiteSpace(Experiences_Text))
                //{
                //    await App.Database.SaveScoreOfReactionAsync(new ScoreOfReaction
                //    {
                //        ReactionScore = int.Parse(Experiences_Text)
                //    });
                //}
            }

            if (_brainsDeletes == 0)
            {

            }
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
                _fifty = 0;
                _additionExperience = _fifty;

                _brainsDeletes = 0;
                _countOfBrainDeletes = _brainsDeletes;

                _nextPage = true;
                await Navigation.PushAsync(new ScoreReactionPage(Experiences_Text));

                if (!string.IsNullOrWhiteSpace(Experiences_Text))
                {
                    await App.Database.SaveScoreOfReactionAsync(new ScoreOfReaction
                    {
                        ReactionScore = int.Parse(Experiences_Text)
                    });
                }
            }
            CreateRandomImage();
        });

        public ReactionGamePageModel01(INavigation navigation)
        {
            Navigation = navigation;
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                _countSeconds--;
                Timer_Text = _countSeconds.ToString();
                return Convert.ToBoolean(_countSeconds);
            });

            Device.StartTimer(TimeSpan.FromSeconds(75), () =>
            {
                if (!_nextPage)
                {

                    Task.Factory.StartNew(async () =>
                    {
                        if (!string.IsNullOrWhiteSpace(Experiences_Text))
                        {
                            await App.Database.SaveScoreOfReactionAsync(new ScoreOfReaction
                            {
                                ReactionScore = int.Parse(Experiences_Text)
                            });
                        }

                    });
                    _fifty = 0;
                    _additionExperience = _fifty;

                    _brainsDeletes = 0;
                    _countOfBrainDeletes = _brainsDeletes;
                    Task.Factory.StartNew(async () =>
                    {
                        await Navigation.PushAsync(new ScoreReactionPage(Experiences_Text));
                    });
                }
                return false;
            });

            CreateRandomImage();
        }
        
        private void CreateRandomImage()
        {
            var rand = new Random();
            var next = rand.Next(9);
            _randomImage = images[next];
            RandomImage_Source = ImageSource.FromFile(_randomImage);
        }
}   }
