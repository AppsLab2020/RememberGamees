using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace RememberGamees.Data
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Experiences { get; set; }
    }
}
