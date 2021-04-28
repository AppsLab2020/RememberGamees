using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.ComponentModel;
using RememberGamees.Pages;
using System.Threading.Tasks;
using Person = RememberGamees.Data.ExperienceOfPerson;

namespace RememberGamees.PageModel
{
    class ReactionGamePageModel01 : INotifyPropertyChanged
    {
        List<string> images = new List<string> { "Image1", "Image2", "Image3", "Image4", "Image5", "Image6", "Image7", "Image8", "Image8", "Image9" };
        private string defaultTime = "";
        private string randomImage;
        private string setExperience;
        private bool nextPage = false;

        private int _countSeconds = 75;
        private int CountdownBrains;
        private int brainsDeletes = 0;
        private int AdditionExperience;
        private int fifty;

        private ImageSource defaultBrainImage = "FirstBrainImage";
        private ImageSource secondDefaultBrainImage = "SecondBrainImage";
        private ImageSource thirdDefaultBrainImage = "ThirdBrainImage";
        private ImageSource fourthDefaultBrainImage = "FourthBrainImage";
        private ImageSource fifthDefaultBrainImage = "FifthBrainImage";
        private ImageSource firstImage = "Image1";
        private ImageSource secondImage = "Image2";
        private ImageSource thirdImage = "Image3";
        private ImageSource fourthImage = "Image4";
        private ImageSource fivethImage = "Image5";
        private ImageSource sixthImage = "Image6";
        private ImageSource seventhImage = "Image7";
        private ImageSource eighthImage = "Image8";
        private ImageSource ninethImage = "Image9";
        public INavigation Navigation { get; set; }
        public ImageSource FifthBrain
        {
            get => fifthDefaultBrainImage;
            set
            {
                fifthDefaultBrainImage = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(FifthBrain)));
            }
        }

        public ImageSource FourthBrain
        {
            get => fourthDefaultBrainImage;
            set
            {
                fourthDefaultBrainImage = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(FourthBrain)));
            }
        }

        public ImageSource ThirdBrain
        {
            get => thirdDefaultBrainImage;
            set
            {
                thirdDefaultBrainImage = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(ThirdBrain)));
            }
        }

        public ImageSource SecondBrain
        {
            get => secondDefaultBrainImage;
            set
            {
                secondDefaultBrainImage = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(SecondBrain)));
            }
        }

        public ImageSource FirstBrain
        {
            get => defaultBrainImage;
            set
            {
                defaultBrainImage = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(FirstBrain)));
            }
        }

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

        public string Experiences
        {
            get => setExperience;
            set
            {
                setExperience = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Experiences)));
            }
        }
        
        public string TimerTxt
        {
            get => defaultTime;
            set
            {
                defaultTime = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(TimerTxt)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Command firstBtn_Clicked => new Command(async () =>
        {           
            if (randomImage == "Image1" || randomImage == "Image6" || randomImage == "Image8")
            {
                fifty = AdditionExperience + 50;
                AdditionExperience = fifty;
                Experiences = fifty.ToString();
            }
            else if (randomImage == "Image2" || randomImage == "Image3" || randomImage == "Image4" || randomImage == "Image5" || randomImage == "Image7" || randomImage == "Image9")
            {
                brainsDeletes = CountdownBrains + 1;
                CountdownBrains = brainsDeletes;
            }
            else
            {
                fifty = 0;
                AdditionExperience = fifty;

                brainsDeletes = 0;
                CountdownBrains = brainsDeletes;
                nextPage = true;
                await Navigation.PushAsync(new ScoreReactionPage(Experiences));

                if (!string.IsNullOrWhiteSpace(Experiences))
                {
                    await App.Database.SavePersonAsync(new Person
                    {
                        Results = int.Parse(Experiences)
                    });
                }
            }

            if(brainsDeletes == 0)
            {}
            else if (brainsDeletes == 1)
            {
                FirstBrain = "Null";
            }
            else if (brainsDeletes == 2)
            {
                SecondBrain = "Null";
            }
            else if (brainsDeletes == 3)
            {
                ThirdBrain = "Null";
            }
            else if (brainsDeletes == 4)
            {
                FourthBrain = "Null";
            }
            else
            {
                fifty = 0;
                AdditionExperience = fifty;

                brainsDeletes = 0;
                CountdownBrains = brainsDeletes;

                nextPage = true;
                await Navigation.PushAsync(new ScoreReactionPage(Experiences));

                if (!string.IsNullOrWhiteSpace(Experiences))
                {
                    await App.Database.SavePersonAsync(new Person
                    {
                        Results = int.Parse(Experiences)
                    });
                }
            }

            CreateRandomImage();
        });

        public Command secondBtn_Clicked => new Command(async () =>
        {           
            if (randomImage == "Image3" || randomImage == "Image5" || randomImage == "Image7")
            {
                fifty = AdditionExperience + 50;
                AdditionExperience = fifty;
                Experiences = fifty.ToString();
            }
            else if (randomImage == "Image1" || randomImage == "Image2" || randomImage == "Image4" || randomImage == "Image6" || randomImage == "Image8" || randomImage == "Image9")
            {
                brainsDeletes = CountdownBrains + 1;
                CountdownBrains = brainsDeletes;
            }
            else
            {
                fifty = 0;
                AdditionExperience = fifty;

                brainsDeletes = 0;
                CountdownBrains = brainsDeletes;
                nextPage = true;
                await Navigation.PushAsync(new ScoreReactionPage(Experiences));

                if (!string.IsNullOrWhiteSpace(Experiences))
                {
                    await App.Database.SavePersonAsync(new Person
                    {
                        Results = int.Parse(Experiences)
                    });
                }
            }

            if (brainsDeletes == 0)
            {}
            else if (brainsDeletes == 1)
            {
                FirstBrain = "Null";
            }
            else if (brainsDeletes == 2)
            {
                SecondBrain = "Null";
            }
            else if (brainsDeletes == 3)
            {
                ThirdBrain = "Null";
            }
            else if (brainsDeletes == 4)
            {
                FourthBrain = "Null";
            }
            else
            {
                fifty = 0;
                AdditionExperience = fifty;

                brainsDeletes = 0;
                CountdownBrains = brainsDeletes;

                nextPage = true;
                await Navigation.PushAsync(new ScoreReactionPage(Experiences));

                if (!string.IsNullOrWhiteSpace(Experiences))
                {
                    await App.Database.SavePersonAsync(new Person
                    {
                        Results = int.Parse(Experiences)
                    });
                }
            }
            CreateRandomImage();
        });

        public Command thirdBtn_Clicked => new Command(async () =>
        {
            if (randomImage == "Image2" || randomImage == "Image4" || randomImage == "Image9")
            {
                fifty = AdditionExperience + 50;
                AdditionExperience = fifty;
                Experiences = fifty.ToString();
            }
            else if (randomImage == "Image1" || randomImage == "Image3" || randomImage == "Image5" || randomImage == "Image6" || randomImage == "Image7" || randomImage == "Image8")
            {
                brainsDeletes = CountdownBrains + 1;
                CountdownBrains = brainsDeletes;
            }
            else
            {
                fifty = 0;
                AdditionExperience = fifty;

                brainsDeletes = 0;
                CountdownBrains = brainsDeletes;
                nextPage = true;
                await Navigation.PushAsync(new ScoreReactionPage(Experiences));

                if (!string.IsNullOrWhiteSpace(Experiences))
                {
                    await App.Database.SavePersonAsync(new Person
                    {
                        Results = int.Parse(Experiences)
                    });
                }
            }

            if (brainsDeletes == 0)
            {

            }
            else if (brainsDeletes == 1)
            {
                FirstBrain = "Null";
            }
            else if (brainsDeletes == 2)
            {
                SecondBrain = "Null";
            }
            else if (brainsDeletes == 3)
            {
                ThirdBrain = "Null";
            }
            else if (brainsDeletes == 4)
            {
                FourthBrain = "Null";
            }
            else
            {
                fifty = 0;
                AdditionExperience = fifty;

                brainsDeletes = 0;
                CountdownBrains = brainsDeletes;

                nextPage = true;
                await Navigation.PushAsync(new ScoreReactionPage(Experiences));

                if (!string.IsNullOrWhiteSpace(Experiences))
                {
                    await App.Database.SavePersonAsync(new Person
                    {
                        Results = int.Parse(Experiences)
                    });
                }
            }
            CreateRandomImage();
        });

        public ReactionGamePageModel01(INavigation navigation)
        {
            this.Navigation = navigation;
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                _countSeconds--;
                TimerTxt = _countSeconds.ToString();
                return Convert.ToBoolean(_countSeconds);
            });

            Device.StartTimer(TimeSpan.FromSeconds(75), () =>
            {
                if (!nextPage)
                {

                    Task.Factory.StartNew(async () =>
                    {
                        await Navigation.PushAsync(new ScoreReactionPage(Experiences));


                        if (!string.IsNullOrWhiteSpace(Experiences))
                        {
                            await App.Database.SavePersonAsync(new Person
                            {
                                Results = int.Parse(Experiences)
                            });
                        }
                    });
                    

                    fifty = 0;
                    AdditionExperience = fifty;

                    brainsDeletes = 0;
                    CountdownBrains = brainsDeletes;
                }
                return false;
            });

            CreateRandomImage();
        }
        
        private void CreateRandomImage()
        {
            var rand = new Random();
            var next = rand.Next(9);
            randomImage = images[next];
            RandomI = ImageSource.FromFile(randomImage);
        }
}   }
