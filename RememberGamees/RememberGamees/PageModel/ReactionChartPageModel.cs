using RememberGamees.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RememberGamees.PageModel
{
    public class ReactionChartPageModel : INotifyPropertyChanged
    {
        private List<ScoreOfReaction> _setExperience;

        public List<ScoreOfReaction> ChartData
        {
            get => _setExperience;
            set
            {
                _setExperience = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(ChartData)));
            }
        }

        internal async System.Threading.Tasks.Task GetScoreOfReactionAsync()
        {
            ChartData = await App.Database.GetScoreOfReactionAsync();
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
