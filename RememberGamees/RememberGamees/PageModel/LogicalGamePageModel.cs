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

        private string _mennuText;
        private string _firstText;
        private string _secondText;
        private string _thirdText;
        private string _fourthText;
        private string _fivethText;
        private string _sixthText;
        private string _seventhText;
        private string _eighthText;
        private string _ninethText;

        private Command _mennuButton;
        private Command _firstButton;
        private Command _secondButton;
        private Command _thirdButton;
        private Command _fourthButton;
        private Command _fivethButton;
        private Command _sixthButton;
        private Command _seventhButton;
        private Command _eighthButton;
        private Command _ninethButton;

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

        public string Mennu_Text
        {
            get => _mennuText;
            set
            {
                _mennuText = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Mennu_Text)));
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

        public Command Mennu_Button
        {
            get => _mennuButton;
            set
            {
                _mennuButton = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(Mennu_Button)));
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
                        _tenthText = "X";
                    }
                    else
                    {
                        First_Text = "O";
                        _tenthText = "O";
                    }

                    _tapped1 = !_tapped1;
                    EnabledClick1 = false;

                if (!EnabledClick2 && Second_Text == Third_Text && First_Text == Second_Text || !EnabledClick4 && Fourth_Text == Fiveth_Text && Fiveth_Text == Sixth_Text || !EnabledClick7 && Seventh_Text == Eighth_Text && Eighth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fourth_Text && Fourth_Text == Seventh_Text || !EnabledClick2 && Second_Text == Fiveth_Text && Fiveth_Text == Eighth_Text || !EnabledClick3 && Third_Text == Sixth_Text && Sixth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fiveth_Text && Fiveth_Text == Nineth_Text || !EnabledClick3 && Third_Text == Fiveth_Text && Fiveth_Text == Seventh_Text)
                {
                    await Application.Current.MainPage.DisplayAlert("Winner is-> " + _tenthText, "Well done", "Cancel");
                    EnabledClick1 = false;
                    EnabledClick2 = false;
                    EnabledClick3 = false;
                    EnabledClick4 = false;
                    EnabledClick5 = false;
                    EnabledClick6 = false;
                    EnabledClick7 = false;
                    EnabledClick8 = false;
                    EnabledClick9 = false;

                    Mennu_Text = "Go back to mennu";

                    Mennu_Button = new Command(async () =>
                    {
                        await navigation.PushAsync(new GamePage());
                    });
                }
                else if (!EnabledClick1 && !EnabledClick2 && !EnabledClick3 && !EnabledClick4 && !EnabledClick5 && !EnabledClick6 && !EnabledClick7 && !EnabledClick8 && !EnabledClick9)
                {
                    await Application.Current.MainPage.DisplayAlert("There is not the winner", "", "Cancel");

                    Mennu_Text = "Go back to mennu";

                    Mennu_Button = new Command(async () =>
                    {
                        await navigation.PushAsync(new GamePage());
                    });
                }
            });

            Second_Button = new Command( async() =>
            {
                    if (_tapped1)
                    {
                        Second_Text = "X";
                        _tenthText = "X";
                    }
                    else
                    {
                        Second_Text = "O";
                        _tenthText = "O";
                    }

                    _tapped1 = !_tapped1;
                    EnabledClick2 = false;

                if (!EnabledClick2 && Second_Text == Third_Text && First_Text == Second_Text || !EnabledClick4 && Fourth_Text == Fiveth_Text && Fiveth_Text == Sixth_Text || !EnabledClick7 && Seventh_Text == Eighth_Text && Eighth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fourth_Text && Fourth_Text == Seventh_Text || !EnabledClick2 && Second_Text == Fiveth_Text && Fiveth_Text == Eighth_Text || !EnabledClick3 && Third_Text == Sixth_Text && Sixth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fiveth_Text && Fiveth_Text == Nineth_Text || !EnabledClick3 && Third_Text == Fiveth_Text && Fiveth_Text == Seventh_Text)
                {
                    await Application.Current.MainPage.DisplayAlert("Winner is -> " + _tenthText, "Well done", "Cancel");
                    EnabledClick1 = false;
                    EnabledClick2 = false;
                    EnabledClick3 = false;
                    EnabledClick4 = false;
                    EnabledClick5 = false;
                    EnabledClick6 = false;
                    EnabledClick7 = false;
                    EnabledClick8 = false;
                    EnabledClick9 = false;
                    Mennu_Text = "Go back to mennu";

                    Mennu_Button = new Command(async () =>
                    {
                        await navigation.PushAsync(new GamePage());
                    });
                }
                else if (!EnabledClick1 && !EnabledClick2 && !EnabledClick3 && !EnabledClick4 && !EnabledClick5 && !EnabledClick6 && !EnabledClick7 && !EnabledClick8 && !EnabledClick9)
                {
                    await Application.Current.MainPage.DisplayAlert("There is not the winner", "", "Cancel");

                    Mennu_Text = "Go back to mennu";

                    Mennu_Button = new Command(async () =>
                    {
                        await navigation.PushAsync(new GamePage());
                    });
                }
            });

            Third_Button = new Command( async() =>
            {
                    if (_tapped1)
                    {
                        Third_Text = "X";
                        _tenthText = "X";
                    }
                    else
                    {
                        Third_Text = "O";
                        _tenthText = "O";
                    }

                    _tapped1 = !_tapped1;
                    EnabledClick3 = false;

                if (!EnabledClick2 && Second_Text == Third_Text && First_Text == Second_Text || !EnabledClick4 && Fourth_Text == Fiveth_Text && Fiveth_Text == Sixth_Text || !EnabledClick7 && Seventh_Text == Eighth_Text && Eighth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fourth_Text && Fourth_Text == Seventh_Text || !EnabledClick2 && Second_Text == Fiveth_Text && Fiveth_Text == Eighth_Text || !EnabledClick3 && Third_Text == Sixth_Text && Sixth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fiveth_Text && Fiveth_Text == Nineth_Text || !EnabledClick3 && Third_Text == Fiveth_Text && Fiveth_Text == Seventh_Text)
                {
                    await Application.Current.MainPage.DisplayAlert("Winner is -> " + _tenthText, "Well done", "Cancel");
                    EnabledClick1 = false;
                    EnabledClick2 = false;
                    EnabledClick3 = false;
                    EnabledClick4 = false;
                    EnabledClick5 = false;
                    EnabledClick6 = false;
                    EnabledClick7 = false;
                    EnabledClick8 = false;
                    EnabledClick9 = false;
                    Mennu_Text = "Go back to mennu";

                    Mennu_Button = new Command(async () =>
                    {
                        await navigation.PushAsync(new GamePage());
                    });
                }
                else if (!EnabledClick1 && !EnabledClick2 && !EnabledClick3 && !EnabledClick4 && !EnabledClick5 && !EnabledClick6 && !EnabledClick7 && !EnabledClick8 && !EnabledClick9)
                {
                    await Application.Current.MainPage.DisplayAlert("There is not the winner", "", "Cancel");

                    Mennu_Text = "Go back to mennu";

                    Mennu_Button = new Command(async () =>
                    {
                        await navigation.PushAsync(new GamePage());
                    });
                }
            });

            Fourth_Button = new Command( async() =>
            {
                    if (_tapped1)
                    {
                        Fourth_Text = "X";
                        _tenthText = "X";
                    }
                    else
                    {
                        Fourth_Text = "O";
                        _tenthText = "O";
                    }

                    _tapped1 = !_tapped1;
                    EnabledClick4 = false;

                if (!EnabledClick2 && Second_Text == Third_Text && First_Text == Second_Text || !EnabledClick4 && Fourth_Text == Fiveth_Text && Fiveth_Text == Sixth_Text || !EnabledClick7 && Seventh_Text == Eighth_Text && Eighth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fourth_Text && Fourth_Text == Seventh_Text || !EnabledClick2 && Second_Text == Fiveth_Text && Fiveth_Text == Eighth_Text || !EnabledClick3 && Third_Text == Sixth_Text && Sixth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fiveth_Text && Fiveth_Text == Nineth_Text || !EnabledClick3 && Third_Text == Fiveth_Text && Fiveth_Text == Seventh_Text)
                {
                    await Application.Current.MainPage.DisplayAlert("Winner is -> " + _tenthText, "Well done", "Cancel");
                    EnabledClick1 = false;
                    EnabledClick2 = false;
                    EnabledClick3 = false;
                    EnabledClick4 = false;
                    EnabledClick5 = false;
                    EnabledClick6 = false;
                    EnabledClick7 = false;
                    EnabledClick8 = false;
                    EnabledClick9 = false;
                    Mennu_Text = "Go back to mennu";

                    Mennu_Button = new Command(async () =>
                    {
                        await navigation.PushAsync(new GamePage());
                    });
                }
                else if (!EnabledClick1 && !EnabledClick2 && !EnabledClick3 && !EnabledClick4 && !EnabledClick5 && !EnabledClick6 && !EnabledClick7 && !EnabledClick8 && !EnabledClick9)
                {
                    await Application.Current.MainPage.DisplayAlert("There is not the winner", "", "Cancel");

                    Mennu_Text = "Go back to mennu";

                    Mennu_Button = new Command(async () =>
                    {
                        await navigation.PushAsync(new GamePage());
                    });
                }
            });

            Fiveth_Button = new Command( async() =>
            {
                    if (_tapped1)
                    {
                        Fiveth_Text = "X";
                        _tenthText = "X";
                    }
                    else
                    {
                        Fiveth_Text = "O";
                        _tenthText = "O";
                    }

                    _tapped1 = !_tapped1;
                    EnabledClick5 = false;

                if (!EnabledClick2 && Second_Text == Third_Text && First_Text == Second_Text || !EnabledClick4 && Fourth_Text == Fiveth_Text && Fiveth_Text == Sixth_Text || !EnabledClick7 && Seventh_Text == Eighth_Text && Eighth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fourth_Text && Fourth_Text == Seventh_Text || !EnabledClick2 && Second_Text == Fiveth_Text && Fiveth_Text == Eighth_Text || !EnabledClick3 && Third_Text == Sixth_Text && Sixth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fiveth_Text && Fiveth_Text == Nineth_Text || !EnabledClick3 && Third_Text == Fiveth_Text && Fiveth_Text == Seventh_Text)
                {
                    await Application.Current.MainPage.DisplayAlert("Winner is -> " + _tenthText, "Well done", "Cancel");
                    EnabledClick1 = false;
                    EnabledClick2 = false;
                    EnabledClick3 = false;
                    EnabledClick4 = false;
                    EnabledClick5 = false;
                    EnabledClick6 = false;
                    EnabledClick7 = false;
                    EnabledClick8 = false;
                    EnabledClick9 = false;
                    Mennu_Text = "Go back to mennu";

                    Mennu_Button = new Command(async () =>
                    {
                        await navigation.PushAsync(new GamePage());
                    });
                }
                else if (!EnabledClick1 && !EnabledClick2 && !EnabledClick3 && !EnabledClick4 && !EnabledClick5 && !EnabledClick6 && !EnabledClick7 && !EnabledClick8 && !EnabledClick9)
                {
                    await Application.Current.MainPage.DisplayAlert("There is not the winner", "", "Cancel");

                    Mennu_Text = "Go back to mennu";

                    Mennu_Button = new Command(async () =>
                    {
                        await navigation.PushAsync(new GamePage());
                    });
                }
            });

            Sixth_Button = new Command( async() =>
            {
                    if (_tapped1)
                    {
                        Sixth_Text = "X";
                        _tenthText = "X";
                    }
                    else
                    {
                        Sixth_Text = "O";
                        _tenthText = "O";
                    }

                    _tapped1 = !_tapped1;
                    EnabledClick6 = false;

                if (!EnabledClick2 && Second_Text == Third_Text && First_Text == Second_Text || !EnabledClick4 && Fourth_Text == Fiveth_Text && Fiveth_Text == Sixth_Text || !EnabledClick7 && Seventh_Text == Eighth_Text && Eighth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fourth_Text && Fourth_Text == Seventh_Text || !EnabledClick2 && Second_Text == Fiveth_Text && Fiveth_Text == Eighth_Text || !EnabledClick3 && Third_Text == Sixth_Text && Sixth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fiveth_Text && Fiveth_Text == Nineth_Text || !EnabledClick3 && Third_Text == Fiveth_Text && Fiveth_Text == Seventh_Text)
                {
                    await Application.Current.MainPage.DisplayAlert("Winner is -> " + _tenthText, "Well done", "Cancel");
                    EnabledClick1 = false;
                    EnabledClick2 = false;
                    EnabledClick3 = false;
                    EnabledClick4 = false;
                    EnabledClick5 = false;
                    EnabledClick6 = false;
                    EnabledClick7 = false;
                    EnabledClick8 = false;
                    EnabledClick9 = false;
                    Mennu_Text = "Go back to mennu";

                    Mennu_Button = new Command(async () =>
                    {
                        await navigation.PushAsync(new GamePage());
                    });
                }
                else if (!EnabledClick1 && !EnabledClick2 && !EnabledClick3 && !EnabledClick4 && !EnabledClick5 && !EnabledClick6 && !EnabledClick7 && !EnabledClick8 && !EnabledClick9)
                {
                    await Application.Current.MainPage.DisplayAlert("There is not the winner", "", "Cancel");

                    Mennu_Text = "Go back to mennu";

                    Mennu_Button = new Command(async () =>
                    {
                        await navigation.PushAsync(new GamePage());
                    });
                }
            });

            Seventh_Button = new Command( async() =>
            {
                if (_tapped1)
                {
                    Seventh_Text = "X";
                    _tenthText = "X";
                }
                else
                {
                    Seventh_Text = "O";
                    _tenthText = "O";
                }

                _tapped1 = !_tapped1;
                EnabledClick7 = false;

                if (!EnabledClick2 && Second_Text == Third_Text && First_Text == Second_Text || !EnabledClick4 && Fourth_Text == Fiveth_Text && Fiveth_Text == Sixth_Text || !EnabledClick7 && Seventh_Text == Eighth_Text && Eighth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fourth_Text && Fourth_Text == Seventh_Text || !EnabledClick2 && Second_Text == Fiveth_Text && Fiveth_Text == Eighth_Text || !EnabledClick3 && Third_Text == Sixth_Text && Sixth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fiveth_Text && Fiveth_Text == Nineth_Text || !EnabledClick3 && Third_Text == Fiveth_Text && Fiveth_Text == Seventh_Text)
                {
                    await Application.Current.MainPage.DisplayAlert("Winner is -> " + _tenthText, "Well done", "Cancel");
                    EnabledClick1 = false;
                    EnabledClick2 = false;
                    EnabledClick3 = false;
                    EnabledClick4 = false;
                    EnabledClick5 = false;
                    EnabledClick6 = false;
                    EnabledClick7 = false;
                    EnabledClick8 = false;
                    EnabledClick9 = false;
                    Mennu_Text = "Go back to mennu";

                    Mennu_Button = new Command(async () =>
                    {
                        await navigation.PushAsync(new GamePage());
                    });
                }
                else if (!EnabledClick1 && !EnabledClick2 && !EnabledClick3 && !EnabledClick4 && !EnabledClick5 && !EnabledClick6 && !EnabledClick7 && !EnabledClick8 && !EnabledClick9)
                {
                    await Application.Current.MainPage.DisplayAlert("There is not the winner", "", "Cancel");

                    Mennu_Text = "Go back to mennu";

                    Mennu_Button = new Command(async () =>
                    {
                        await navigation.PushAsync(new GamePage());
                    });
                }
            });

            Eighth_Button = new Command( async() =>
            {
                

                if (_tapped1)
                {
                    Eighth_Text = "X";
                    _tenthText = "X";
                }
                else
                {
                    Eighth_Text = "O";
                    _tenthText = "O";
                }

                _tapped1 = !_tapped1;
                EnabledClick8 = false;

                if (!EnabledClick2 && Second_Text == Third_Text && First_Text == Second_Text || !EnabledClick4 && Fourth_Text == Fiveth_Text && Fiveth_Text == Sixth_Text || !EnabledClick7 && Seventh_Text == Eighth_Text && Eighth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fourth_Text && Fourth_Text == Seventh_Text || !EnabledClick2 && Second_Text == Fiveth_Text && Fiveth_Text == Eighth_Text || !EnabledClick3 && Third_Text == Sixth_Text && Sixth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fiveth_Text && Fiveth_Text == Nineth_Text || !EnabledClick3 && Third_Text == Fiveth_Text && Fiveth_Text == Seventh_Text)
                {
                    await Application.Current.MainPage.DisplayAlert("Winner is -> " + _tenthText, "Well done", "Cancel");
                    EnabledClick1 = false;
                    EnabledClick2 = false;
                    EnabledClick3 = false;
                    EnabledClick4 = false;
                    EnabledClick5 = false;
                    EnabledClick6 = false;
                    EnabledClick7 = false;
                    EnabledClick8 = false;
                    EnabledClick9 = false;
                    Mennu_Text = "Go back to mennu";

                    Mennu_Button = new Command(async () =>
                    {
                        await navigation.PushAsync(new GamePage());
                    });
                }
                else if (!EnabledClick1 && !EnabledClick2 && !EnabledClick3 && !EnabledClick4 && !EnabledClick5 && !EnabledClick6 && !EnabledClick7 && !EnabledClick8 && !EnabledClick9)
                {
                    await Application.Current.MainPage.DisplayAlert("There is not the winner", "", "Cancel");

                    Mennu_Text = "Go back to mennu";

                    Mennu_Button = new Command(async () =>
                    {
                        await navigation.PushAsync(new GamePage());
                    });
                }
            });

            Nineth_Button = new Command( async() =>
            {
               
                
                if (_tapped1)
                {
                    Nineth_Text = "X";
                    _tenthText = "X";
                }
                else
                {
                    Nineth_Text = "O";
                    _tenthText = "O";
                }

                _tapped1 = !_tapped1;                        //find if button was clicked, if true X or 0 doesnt change
                EnabledClick9 = false;

                if ( !EnabledClick2 && Second_Text == Third_Text && First_Text == Second_Text || !EnabledClick4 && Fourth_Text == Fiveth_Text && Fiveth_Text == Sixth_Text || !EnabledClick7 && Seventh_Text == Eighth_Text && Eighth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fourth_Text && First_Text == Seventh_Text || !EnabledClick2 && Second_Text == Fiveth_Text && Fiveth_Text == Eighth_Text || !EnabledClick3 && Third_Text == Sixth_Text && Sixth_Text == Nineth_Text || !EnabledClick1 && First_Text == Fiveth_Text && Fiveth_Text == Nineth_Text || !EnabledClick3 && Third_Text == Fiveth_Text && Fiveth_Text == Seventh_Text)
                {
                    await Application.Current.MainPage.DisplayAlert("Winner is -> " + _tenthText, "Well done", "Cancel");
                    EnabledClick1 = false;
                    EnabledClick2 = false;
                    EnabledClick3 = false;
                    EnabledClick4 = false;
                    EnabledClick5 = false;
                    EnabledClick6 = false;
                    EnabledClick7 = false;
                    EnabledClick8 = false;
                    EnabledClick9 = false;
                    Mennu_Text = "Go back to mennu";

                    Mennu_Button = new Command(async () =>
                    {
                        await navigation.PushAsync(new GamePage());
                    });
                }
                else if (!EnabledClick1 && !EnabledClick2 && !EnabledClick3 && !EnabledClick4 && !EnabledClick5 && !EnabledClick6 && !EnabledClick7 && !EnabledClick8 && !EnabledClick9)
                {
                    await Application.Current.MainPage.DisplayAlert("There is not the winner", "", "Cancel");

                    Mennu_Text = "Go back to mennu";

                    Mennu_Button = new Command(async () =>
                    {
                        await navigation.PushAsync(new GamePage());
                    });
                }
            });
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private bool _tapped1;
        private string _tenthText;
    }
}
