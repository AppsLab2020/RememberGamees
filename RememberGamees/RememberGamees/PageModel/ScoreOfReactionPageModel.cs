using RememberGamees.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace RememberGamees.PageModel
{
    class ScoreOfReactionPageModel : INotifyPropertyChanged
    {
        public ScoreOfReactionPageModel()
        {

        }

        private INavigation navigation;

        public ScoreOfReactionPageModel(INavigation navigation)
        {
            this.navigation = navigation;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public INavigation Navigation { get; }
    }
}
