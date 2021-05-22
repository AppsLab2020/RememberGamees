using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace RememberGamees.Data
{
    public class ScoreOfMath
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int MathScore { get; set; }
    }
}
