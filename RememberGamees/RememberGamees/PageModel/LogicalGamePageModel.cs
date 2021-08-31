using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace RememberGamees.PageModel
{
    public class LogicalGamePageModel : INotifyPropertyChanged
    {
        private readonly List<DateTime> tapTimes;

        private string _firstText;
        private string _secondText;
        private string _thirdText;
        private string _fourthText;
        private string _fivethText;
        private string _sixthText;
        private string _seventhText;
        private string _eighthText;
        private string _ninethText;

        private Command _firstButton;
        private Command _secondButton;
        private Command _thirdButton;
        private Command _fourthButton;
        private Command _fivethButton;
        private Command _sixthButton;
        private Command _seventhButton;
        private Command _eighthButton;
        private Command _ninethButton;

        public int OneHigher_Num
        {
            get => _oneHigher;
            set
            {
                _oneHigher = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(OneHigher_Num)));
            }
        }

        public string First_Text
        {
            get => _firstText;
            set
            {
                _firstText = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(First_Text)));
            }
        }
        public string Second_Text
        {
            get => _secondText;
            set
            {
                _secondText = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Second_Text)));
            }
        }
        public string Third_Text
        {
            get => _thirdText;
            set
            {
                _thirdText = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Third_Text)));
            }
        }
        public string Fourth_Text
        {
            get => _fourthText;
            set
            {
                _fourthText = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Fourth_Text)));
            }
        }
        public string Fiveth_Text
        {
            get => _fivethText;
            set
            {
                _fivethText = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Fiveth_Text)));
            }
        }
        public string Sixth_Text
        {
            get => _sixthText;
            set
            {
                _sixthText = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Sixth_Text)));
            }
        }
        public string Seventh_Text
        {
            get => _seventhText;
            set
            {
                _seventhText = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Seventh_Text)));
            }
        }
        public string Eighth_Text
        {
            get => _eighthText;
            set
            {
                _eighthText = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Eighth_Text)));
            }
        }
        public string Nineth_Text
        {
            get => _ninethText;
            set
            {
                _ninethText = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Nineth_Text)));
            }
        }

        public Command First_Button
        {
            get => _firstButton;
            set
            {
                _firstButton = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(First_Button)));
            }
        }

        public Command Second_Button
        {
            get => _secondButton;
            set
            {
                _secondButton = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Second_Button)));
            }
        }
        public Command Third_Button
        {
            get => _thirdButton;
            set
            {
                _thirdButton = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Third_Button)));
            }
        }
        public Command Fourth_Button
        {
            get => _fourthButton;
            set
            {
                _fourthButton = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Fourth_Button)));
            }
        }
        public Command Fiveth_Button
        {
            get => _fivethButton;
            set
            {
                _fivethButton = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Fiveth_Button)));
            }
        }
        public Command Sixth_Button
        {
            get => _sixthButton;
            set
            {
                _sixthButton = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Sixth_Button)));
            }
        }
        public Command Seventh_Button
        {
            get => _seventhButton;
            set
            {
                _seventhButton = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Seventh_Button)));
            }
        }
        public Command Eighth_Button
        {
            get => _eighthButton;
            set
            {
                _eighthButton = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Eighth_Button)));
            }
        }
        public Command Nineth_Button
        {
            get => _ninethButton;
            set
            {
                _ninethButton = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Nineth_Button)));
            }
        }
        public LogicalGamePageModel()
        {

            First_Button = new Command( () =>
            {
                if (_tapped1 == true)
                {

                }
                else
                {
                    GenerateHigherNum();
                    if (OneHigher_Num % 2 == 0)
                    {
                        First_Text = "X";
                    }
                    else
                    {
                        First_Text = "0";
                    }
                }
                _tapped1 = true;
            });

            Second_Button = new Command(() =>
            {
                if (_tapped2 == true)
                {
                    
                }
                else
                {
                    GenerateHigherNum();
                    if (OneHigher_Num % 2 == 0)
                    {
                        Second_Text = "X";
                    }
                    else
                    {
                        Second_Text = "0";
                    }
                }
                _tapped2 = true;
            });

            Third_Button = new Command(() =>
            {
                if (_tapped3 == true)
                {
                    
                }
                else
                {
                    GenerateHigherNum();
                    if (OneHigher_Num % 2 == 0)
                    {
                        Third_Text = "X";
                    }
                    else
                    {
                        Third_Text = "0";
                    }
                }
                
                _tapped3 = true;
            });

            Fourth_Button = new Command(() =>
            {
                if (_tapped4 == true)
                {

                }
                else
                {
                    GenerateHigherNum();
                    if (OneHigher_Num % 2 == 0)
                    {
                        Fourth_Text = "X";
                    }
                    else
                    {
                        Fourth_Text = "0";
                    }
                }

                _tapped4 = true;
            });

            Fiveth_Button = new Command(() =>
            {
                if (_tapped5 == true)
                {

                }
                else
                {
                    GenerateHigherNum();
                    if (OneHigher_Num % 2 == 0)
                    {
                        Fiveth_Text = "X";
                    }
                    else
                    {
                        Fiveth_Text = "0";
                    }
                }

                _tapped5 = true;
            });

            Sixth_Button = new Command(() =>
            {
                if (_tapped6 == true)
                {
                }
                else
                {
                    GenerateHigherNum();
                    if (OneHigher_Num % 2 == 0)
                    {
                        Sixth_Text = "X";
                    }
                    else
                    {
                        Sixth_Text = "0";
                    }
                }
    
                _tapped6 = true;
            });

            Seventh_Button = new Command(() =>
            {
                if (_tapped7 == true)
                {

                }
                else
                {
                    GenerateHigherNum();
                    if (OneHigher_Num % 2 == 0)
                    {
                        Seventh_Text = "X";
                    }
                    else
                    {
                        Seventh_Text = "0";
                    }
                }
                _tapped7 = true;
            });

            Eighth_Button = new Command(() =>
            {
                if (_tapped8 == true)
                {

                }
                else
                {
                    GenerateHigherNum();
                    if (OneHigher_Num % 2 == 0)
                    {
                        Eighth_Text = "X";
                    }
                    else
                    {
                        Eighth_Text = "0";
                    }
                }

                _tapped8 = true;
            });

            Nineth_Button = new Command(() =>
            {
                if (_tapped9 == true)
                {

                }
                else
                {
                    GenerateHigherNum();
                    if (OneHigher_Num % 2 == 0)
                    {
                        Nineth_Text = "X";
                    }
                    else
                    {
                        Nineth_Text = "0";
                    }
                }

                _tapped9 = true;
            });
        }
        void GenerateHigherNum()
        {
            OneHigher_Num++;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private int _oneHigher;
        private bool _tapped1;
        private bool _tapped2;
        private bool _tapped3;
        private bool _tapped4;
        private bool _tapped5;
        private bool _tapped6;
        private bool _tapped7;
        private bool _tapped8;
        private bool _tapped9;
    }
}
