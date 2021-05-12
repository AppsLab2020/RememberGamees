using RememberGamees.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RememberGamees.PageModel
{
    public class MemoryChartPageModel : INotifyPropertyChanged
    {
        private List<ScoreOfMemory> _setExperience;

        public List<ScoreOfMemory> ChartData
        {
            get => _setExperience;
            set
            {
                _setExperience = value;
                PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(nameof(ChartData)));
            }
        }

        internal async System.Threading.Tasks.Task GetScoreOfMemoryAsync()
        {
            ChartData = await App.Database.GetScoreOfMemoryAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
