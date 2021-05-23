using RememberGamees.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RememberGamees.PageModel
{
    public class MathChartPageModel : INotifyPropertyChanged
    {
        private List<ScoreOfMath> _setExperience;

        public List<ScoreOfMath> ChartData
        {
            get => _setExperience;
            set
            {
                _setExperience = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(ChartData)));
            }
        }
        internal async System.Threading.Tasks.Task GetScoreOfMathAsync()
        {
            ChartData = await App.Database.GetScoreOfMathAsync();
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
