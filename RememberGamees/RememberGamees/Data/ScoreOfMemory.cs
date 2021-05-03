using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace RememberGamees.Data
{
    public class ScoreOfMemory
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int MemoryScore { get; set; }
    }
}
