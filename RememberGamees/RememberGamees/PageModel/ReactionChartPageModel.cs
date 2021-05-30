using RememberGamees.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RememberGamees.PageModel
{
    public class ReactionChartPageModel : INotifyPropertyChanged
    {
        public List<ScoreOfReaction> ChartData1 { get; set; }

        public ReactionChartPageModel()
        {
            ChartData1 = new List<ScoreOfReaction>();

            ChartData1.Add(new ScoreOfReaction { ReactionScore = 50});
            ChartData1.Add(new ScoreOfReaction { ReactionScore = 100 });
            ChartData1.Add(new ScoreOfReaction { ReactionScore = 150 });
            ChartData1.Add(new ScoreOfReaction { ReactionScore = 100 });
            ChartData1.Add(new ScoreOfReaction { ReactionScore = 200 });
            ChartData1.Add(new ScoreOfReaction { ReactionScore = 250 });
            ChartData1.Add(new ScoreOfReaction { ReactionScore = 300 });
            ChartData1.Add(new ScoreOfReaction { ReactionScore = 300 });
            ChartData1.Add(new ScoreOfReaction { ReactionScore = 350 });
            ChartData1.Add(new ScoreOfReaction { ReactionScore = 450 });
            ChartData1.Add(new ScoreOfReaction { ReactionScore = 400 });
            ChartData1.Add(new ScoreOfReaction { ReactionScore = 450 });
        }

        //public List<ScoreOfReaction> ChartData
        //{
        //    get => _setExperience;
        //    set
        //    {
        //        _setExperience = value;
        //        PropertyChanged?
        //        .Invoke(this, new PropertyChangedEventArgs(nameof(ChartData)));
        //    }
        //}

        //internal async System.Threading.Tasks.Task GetScoreOfReactionAsync()
        //{
        //    ChartData = await App.Database.GetScoreOfReactionAsync();
        //}
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
