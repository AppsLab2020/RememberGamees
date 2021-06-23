using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace RememberGamees.PageModel
{
    public class LogicalGamePageModel : INotifyPropertyChanged
    {
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

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
