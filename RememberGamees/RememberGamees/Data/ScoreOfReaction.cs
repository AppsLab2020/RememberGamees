using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace RememberGamees.Data
{
    public class ScoreOfReaction
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int ReactionScore { get; set; }
    }
}
