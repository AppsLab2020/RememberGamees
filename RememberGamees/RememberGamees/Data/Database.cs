using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace RememberGamees.Data
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<ExperienceOfPerson>().Wait();
        }

        public Task<List<ExperienceOfPerson>> GetPeopleAsync()
        {
            return _database.Table<ExperienceOfPerson>().ToListAsync();
        }

        public Task<int> SavePersonAsync(ExperienceOfPerson person)
        {
            return _database.InsertAsync(person);
        }
    }
}
