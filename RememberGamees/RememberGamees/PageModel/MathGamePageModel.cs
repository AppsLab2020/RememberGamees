using RememberGamees.Data;
using RememberGamees.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace RememberGamees.PageModel
{
    public class MathGamePageModel : INotifyPropertyChanged
    {
        private bool _nextPage = false;
        private double _multiple { get; set; }
        private string _writeNumber;
        private int _brainsDeletes;
        private double _numberA { get; set; }
        private double _numberB { get; set; }
        private double _result { get; set; }
        private double _defaultResult { get; set; }
        private double _defaultResult2 { get; set; }
        private double _defaultResult3 { get; set; }
        private double _randDoubleToFind { get; set; }
        private double _randDoubleToFind2;
        private int _defaultScore;
        private Command _defaultCommand01;
        private Command _defaultCommand02;
        private Command _defaultCommand03;
        private double _button1;
        private double _button2;
        private double _button3;
        private ImageSource _defaultBrainImage = "FirstBrainImage";
        private ImageSource _secondDefaultBrainImage = "SecondBrainImage";
        private ImageSource _thirdDefaultBrainImage = "ThirdBrainImage";
        private ImageSource _fourthDefaultBrainImage = "FourthBrainImage";
        private ImageSource _fifthDefaultBrainImage = "FifthBrainImage";

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

        public string WriteNumber_Text
        {
            get => _writeNumber;
            set
            {
                _writeNumber = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(WriteNumber_Text)));
            }
        }

        public double Result_Text
        {
            get => _defaultResult;
            set
            {
                _defaultResult = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Result_Text)));
            }
        }

        public double Result2_Text
        {
            get => _defaultResult2;
            set
            {
                _defaultResult2 = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Result2_Text)));
            }
        }

        public double Result3_Text
        {
            get => _defaultResult3;
            set
            {
                _defaultResult3 = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Result3_Text)));
            }
        }

        public int Score_Text
        {
            get => _defaultScore;
            set
            {
                _defaultScore = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Score_Text)));
            }
        }

        public Command FirstResult_Clicked
        {
            get => _defaultCommand01;
            set
            {
                _defaultCommand01 = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(FirstResult_Clicked)));
            }
        }

        public Command SecondResult_Clicked
        {
            get => _defaultCommand02;
            set
            {
                _defaultCommand02 = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(SecondResult_Clicked)));
            }
        }

        public Command ThirdResult_Clicked
        {
            get => _defaultCommand03;
            set
            {
                _defaultCommand03 = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(ThirdResult_Clicked)));
            }
        }

        public MathGamePageModel(INavigation navigation)
        {

            Random rnd = new Random();
            //double _numberA = rnd.Next(1, 3);
            GenerateRandomNum();

            FirstResult_Clicked = new Command(async () =>
            {
                if (Math.Abs(_button1) < Math.Abs(_button2) && Math.Abs(_button1) < Math.Abs(_button3) || Math.Abs(_button1) < Math.Abs(_button2)  && Math.Abs(_button1) <= Math.Abs(_button3) || Math.Abs(_button1) < Math.Abs(_button3) && Math.Abs(_button1) <= Math.Abs(_button2) || Math.Abs(_button1) == Math.Abs(_button3) && Math.Abs(_button1) == Math.Abs(_button2))
                {
                    Score_Text = _defaultScore + 50;
                    GenerateRandomNum();
                }
                else
                {
                    _brainsDeletes = _brainsDeletes + 1;
                }

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

                    await App.Database.SaveScoreOfMathAsync(new ScoreOfMath
                    {
                        MathScore = Score_Text
                    });
                    await navigation.PushAsync(new ScoreMathPage(Score_Text));
                    _defaultScore = 0;
                    _nextPage = true;
                }
            });

            SecondResult_Clicked = new Command(async () =>
            {
                if (Math.Abs(_button2) < Math.Abs(_button1) && Math.Abs(_button2) < Math.Abs(_button3) || Math.Abs(_button2) < Math.Abs(_button1) && Math.Abs(_button2) <= Math.Abs(_button3) ||  Math.Abs(_button2) < Math.Abs(_button3) && Math.Abs(_button2) <= Math.Abs(_button1) || Math.Abs(_button2) == Math.Abs(_button3) && Math.Abs(_button2) == Math.Abs(_button1))
                {
                    Score_Text = _defaultScore + 50;
                    GenerateRandomNum();
                }
                else
                {
                    _brainsDeletes = _brainsDeletes + 1;
                }

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

                    await App.Database.SaveScoreOfMathAsync(new ScoreOfMath
                    {
                        MathScore = Score_Text
                    });                    
                    await navigation.PushAsync(new ScoreMathPage(Score_Text));
                    _defaultScore = 0;
                    _nextPage = true;
                }
            });

            ThirdResult_Clicked = new Command(async () =>
            {
                if (Math.Abs(_button3) < Math.Abs(_button1) && Math.Abs(_button3) < Math.Abs(_button2) || Math.Abs(_button3) < Math.Abs(_button1) &&  Math.Abs(_button3) <= Math.Abs(_button2) || Math.Abs(_button3) < Math.Abs(_button2) && Math.Abs(_button3) <= Math.Abs(_button1) || Math.Abs(_button3) == Math.Abs(_button2) && Math.Abs(_button3) == Math.Abs(_button1))
                {
                    Score_Text = _defaultScore + 50;
                    GenerateRandomNum();
                }
                else
                {
                    _brainsDeletes = _brainsDeletes + 1;
                }

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

                    await App.Database.SaveScoreOfMathAsync(new ScoreOfMath
                    {
                        MathScore = Score_Text
                    });
                    await navigation.PushAsync(new ScoreMathPage(Score_Text));
                    _defaultScore = 0;
                    _nextPage = true;
                }
            });
            void GenerateRandomNum()
            {
                _numberB = rnd.NextDouble() * (3 - 1) + 1;
                _numberA = rnd.NextDouble() * (3 - 1) + 1;
                _randDoubleToFind = rnd.NextDouble() * (0.5 - 1) + 1;
                _randDoubleToFind2 = rnd.NextDouble() * (0 - 0.4) + 1;
                _randDoubleToFind = Math.Round(_randDoubleToFind, 1);
                _randDoubleToFind2 = Math.Round(_randDoubleToFind2, 1);
                _numberB = Math.Round(_numberB, 1);
                _numberA = Math.Round(_numberA, 1);

                WriteNumber_Text = _numberB.ToString() + " * " + _numberA.ToString() + " =";

                _multiple = _result = _numberB * _numberA;

                Result_Text = _result + _randDoubleToFind;
                Result2_Text = _result - _randDoubleToFind;
                Result3_Text = _result + _randDoubleToFind2;

                _button1 = _multiple - _defaultResult;
                _button2 = _multiple - _defaultResult2;
                _button3 = _multiple - _defaultResult3;
            }
        
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
