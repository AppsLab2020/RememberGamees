using RememberGamees.Pages;
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
        private bool _enabledClick9 = true;
        private bool _enabledClick8 = true;
        private bool _enabledClick7 = true;
        private bool _enabledClick6 = true;
        private bool _enabledClick5 = true;
        private bool _enabledClick4 = true;
        private bool _enabledClick3 = true;
        private bool _enabledClick2 = true;
        private bool _enabledClick1 = true;

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
        public bool EnabledClick9
        {
            get => _enabledClick9;
            set
            {
                _enabledClick9 = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(EnabledClick9)));
            }
        }

        public bool EnabledClick8
        {
            get => _enabledClick8;
            set
            {
                _enabledClick8 = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(EnabledClick8)));
            }
        }

        public bool EnabledClick7
        {
            get => _enabledClick7;
            set
            {
                _enabledClick7 = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(EnabledClick7)));
            }
        }

        public bool EnabledClick6
        {
            get => _enabledClick6;
            set
            {
                _enabledClick6 = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(EnabledClick6)));
            }
        }

        public bool EnabledClick5
        {
            get => _enabledClick5;
            set
            {
                _enabledClick5 = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(EnabledClick5)));
            }
        }

        public bool EnabledClick4
        {
            get => _enabledClick4;
            set
            {
                _enabledClick4 = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(EnabledClick4)));
            }
        }

        public bool EnabledClick3
        {
            get => _enabledClick3;
            set
            {
                _enabledClick3 = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(EnabledClick3)));
            }
        }

        public bool EnabledClick2
        {
            get => _enabledClick2;
            set
            {
                _enabledClick2 = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(EnabledClick2)));
            }
        }

        public bool EnabledClick1
        {
            get => _enabledClick1;
            set
            {
                _enabledClick1 = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(EnabledClick1)));
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
        public LogicalGamePageModel(INavigation navigation)
        {

            First_Button = new Command( async() =>
            {
                    if (_tapped1)
                    {
                        First_Text = "X";
                    }
                    else
                    {
                        First_Text = "O";
                    }

                if (!EnabledClick2 && Second_Text == Third_Text && First_Text == Second_Text || !EnabledClick4 && Fourth_Text == Fiveth_Text && Fiveth_Text == Sixth_Text || !EnabledClick7 && Seventh_Text == Eighth_Text && Eighth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fourth_Text && Fourth_Text == Seventh_Text || !EnabledClick2 && Second_Text == Fiveth_Text && Fiveth_Text == Eighth_Text || !EnabledClick3 && Third_Text == Sixth_Text && Sixth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fiveth_Text && Fiveth_Text == Nineth_Text || !EnabledClick3 && Third_Text == Fiveth_Text && Fiveth_Text == Seventh_Text)
                {
                    await navigation.PushAsync(new GamePage());
                }

                _tapped1 = !_tapped1;
                EnabledClick1 = false;
            });

            Second_Button = new Command( async() =>
            {
                    if (_tapped1)
                    {
                        Second_Text = "X";
                    }
                    else
                    {
                        Second_Text = "O";
                    }

                if (!EnabledClick2 && Second_Text == Third_Text && First_Text == Second_Text || !EnabledClick4 && Fourth_Text == Fiveth_Text && Fiveth_Text == Sixth_Text || !EnabledClick7 && Seventh_Text == Eighth_Text && Eighth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fourth_Text && Fourth_Text == Seventh_Text || !EnabledClick2 && Second_Text == Fiveth_Text && Fiveth_Text == Eighth_Text || !EnabledClick3 && Third_Text == Sixth_Text && Sixth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fiveth_Text && Fiveth_Text == Nineth_Text || !EnabledClick3 && Third_Text == Fiveth_Text && Fiveth_Text == Seventh_Text)
                {
                    await navigation.PushAsync(new GamePage());
                }

                _tapped1 = !_tapped1;
                EnabledClick2 = false;
            });

            Third_Button = new Command( async() =>
            {
                    if (_tapped1)
                    {
                        Third_Text = "X";
                    }
                    else
                    {
                        Third_Text = "O";
                    }

                if (!EnabledClick2 && Second_Text == Third_Text && First_Text == Second_Text || !EnabledClick4 && Fourth_Text == Fiveth_Text && Fiveth_Text == Sixth_Text || !EnabledClick7 && Seventh_Text == Eighth_Text && Eighth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fourth_Text && Fourth_Text == Seventh_Text || !EnabledClick2 && Second_Text == Fiveth_Text && Fiveth_Text == Eighth_Text || !EnabledClick3 && Third_Text == Sixth_Text && Sixth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fiveth_Text && Fiveth_Text == Nineth_Text || !EnabledClick3 && Third_Text == Fiveth_Text && Fiveth_Text == Seventh_Text)
                {
                    await navigation.PushAsync(new GamePage());
                }

                _tapped1 = !_tapped1;
                EnabledClick3 = false;
            });

            Fourth_Button = new Command( async() =>
            {
                    if (_tapped1)
                    {
                        Fourth_Text = "X";
                    }
                    else
                    {
                        Fourth_Text = "O";
                    }

                if (!EnabledClick2 && Second_Text == Third_Text && First_Text == Second_Text || !EnabledClick4 && Fourth_Text == Fiveth_Text && Fiveth_Text == Sixth_Text || !EnabledClick7 && Seventh_Text == Eighth_Text && Eighth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fourth_Text && Fourth_Text == Seventh_Text || !EnabledClick2 && Second_Text == Fiveth_Text && Fiveth_Text == Eighth_Text || !EnabledClick3 && Third_Text == Sixth_Text && Sixth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fiveth_Text && Fiveth_Text == Nineth_Text || !EnabledClick3 && Third_Text == Fiveth_Text && Fiveth_Text == Seventh_Text)
                {
                    await navigation.PushAsync(new GamePage());
                }

                _tapped1 = !_tapped1;
                EnabledClick4 = false;
            });

            Fiveth_Button = new Command( async() =>
            {
                    if (_tapped1)
                    {
                        Fiveth_Text = "X";
                    }
                    else
                    {
                        Fiveth_Text = "O";
                    }

                if (!EnabledClick2 && Second_Text == Third_Text && First_Text == Second_Text || !EnabledClick4 && Fourth_Text == Fiveth_Text && Fiveth_Text == Sixth_Text || !EnabledClick7 && Seventh_Text == Eighth_Text && Eighth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fourth_Text && Fourth_Text == Seventh_Text || !EnabledClick2 && Second_Text == Fiveth_Text && Fiveth_Text == Eighth_Text || !EnabledClick3 && Third_Text == Sixth_Text && Sixth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fiveth_Text && Fiveth_Text == Nineth_Text || !EnabledClick3 && Third_Text == Fiveth_Text && Fiveth_Text == Seventh_Text)
                {
                    await navigation.PushAsync(new GamePage());
                }

                _tapped1 = !_tapped1;
                EnabledClick5 = false;
            });

            Sixth_Button = new Command( async() =>
            {
                    if (_tapped1)
                    {
                        Sixth_Text = "X";
                    }
                    else
                    {
                        Sixth_Text = "O";
                    }

                if (!EnabledClick2 && Second_Text == Third_Text && First_Text == Second_Text || !EnabledClick4 && Fourth_Text == Fiveth_Text && Fiveth_Text == Sixth_Text || !EnabledClick7 && Seventh_Text == Eighth_Text && Eighth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fourth_Text && Fourth_Text == Seventh_Text || !EnabledClick2 && Second_Text == Fiveth_Text && Fiveth_Text == Eighth_Text || !EnabledClick3 && Third_Text == Sixth_Text && Sixth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fiveth_Text && Fiveth_Text == Nineth_Text || !EnabledClick3 && Third_Text == Fiveth_Text && Fiveth_Text == Seventh_Text)
                {
                    await navigation.PushAsync(new GamePage());
                }

                _tapped1 = !_tapped1;
                EnabledClick6 = false;
            });

            Seventh_Button = new Command( async() =>
            {
                if (_tapped1)
                {
                    Seventh_Text = "X";
                }
                else
                {
                    Seventh_Text = "O";
                }

                if (!EnabledClick2 && Second_Text == Third_Text && First_Text == Second_Text || !EnabledClick4 && Fourth_Text == Fiveth_Text && Fiveth_Text == Sixth_Text || !EnabledClick7 && Seventh_Text == Eighth_Text && Eighth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fourth_Text && Fourth_Text == Seventh_Text || !EnabledClick2 && Second_Text == Fiveth_Text && Fiveth_Text == Eighth_Text || !EnabledClick3 && Third_Text == Sixth_Text && Sixth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fiveth_Text && Fiveth_Text == Nineth_Text || !EnabledClick3 && Third_Text == Fiveth_Text && Fiveth_Text == Seventh_Text)
                {
                    await navigation.PushAsync(new GamePage());
                }

                _tapped1 = !_tapped1;
                EnabledClick7 = false;
            });

            Eighth_Button = new Command( async() =>
            {
                

                if (_tapped1)
                {
                    Eighth_Text = "X";
                }
                else
                {
                    Eighth_Text = "O";
                }

                if (!EnabledClick2 && Second_Text == Third_Text && First_Text == Second_Text || !EnabledClick4 && Fourth_Text == Fiveth_Text && Fiveth_Text == Sixth_Text || !EnabledClick7 && Seventh_Text == Eighth_Text && Eighth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fourth_Text && Fourth_Text == Seventh_Text || !EnabledClick2 && Second_Text == Fiveth_Text && Fiveth_Text == Eighth_Text || !EnabledClick3 && Third_Text == Sixth_Text && Sixth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fiveth_Text && Fiveth_Text == Nineth_Text || !EnabledClick3 && Third_Text == Fiveth_Text && Fiveth_Text == Seventh_Text)
                {
                    await navigation.PushAsync(new GamePage());
                }

                _tapped1 = !_tapped1;
                EnabledClick8 = false;
            });

            Nineth_Button = new Command( async() =>
            {
               
                
                if (_tapped1)
                {
                    Nineth_Text = "X";
                }
                else
                {
                    Nineth_Text = "O";
                    GenerateHigherNum();
                    //if (OneHigher_Num % 2 == 0)             //alternate X and 0
                    //{
                    //    Nineth_Text = "X";
                    //    _findCircle9 = false;
                    //}
                    //else
                    //{
                    //    Nineth_Text = "0";
                    //    _findCircle9 = true;
                    //}
                }

                
                if ( !EnabledClick2 && Second_Text == Third_Text && First_Text == Second_Text || !EnabledClick4 && Fourth_Text == Fiveth_Text && Fiveth_Text == Sixth_Text || !EnabledClick7 && Seventh_Text == Eighth_Text && Eighth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fourth_Text && Fourth_Text == Seventh_Text || !EnabledClick2 && Second_Text == Fiveth_Text && Fiveth_Text == Eighth_Text || !EnabledClick3 && Third_Text == Sixth_Text && Sixth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fiveth_Text && Fiveth_Text == Nineth_Text || !EnabledClick3 && Third_Text == Fiveth_Text && Fiveth_Text == Seventh_Text)
                {
                    await navigation.PushAsync(new GamePage());
                }

                _tapped1 = !_tapped1;                        //find if button was clicked, if true X or 0 doesnt change
                EnabledClick9 = false;
            });
        }
        void GenerateHigherNum()
        {
            OneHigher_Num++;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private int _oneHigher;
        private bool _tapped1;

        private bool _findCircle1;
        private bool _findCircle2;
        private bool _findCircle3;
        private bool _findCircle4;
        private bool _findCircle5;
        private bool _findCircle6;
        private bool _findCircle7;
        private bool _findCircle8;
        private bool _findCircle9;
    }
}
