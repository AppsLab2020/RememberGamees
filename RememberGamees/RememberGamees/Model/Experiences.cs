using SQLite;
using System;

namespace RememberGamees.Model
{
    public class Experiences
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
