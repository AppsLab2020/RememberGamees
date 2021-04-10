using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace RememberGamees.Model
{
    class Experiences
    {
        public Experiences()
        {
            ReadAt = DateTime.Now;
        }
        [PrimaryKey, AutoIncrement]
        public int ExperienceNumber { get; set; }
        public DateTime ReadAt { get; set; }
    }
}
