using SQLite;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System;

namespace RememberGamees.Model
{
    public class SQLiteExperiences : INoteRepository
    {
        private SQLiteAsyncConnection _connection;

        public async Task AddExperience(Experiences experiences)
        {
            await _connection.InsertAsync(experiences);
        }

        public Task<List<Experiences>> GetExperience()
        {
            return _connection.Table<Experiences>().ToListAsync();
        }

        public async Task Initialize()
        {
            if (_connection != null) return;

            _connection = new SQLiteAsyncConnection(
                Path.Combine(Xamarin.Essentials.FileSystem.AppDataDirectory, "experiences.db3"));

            await _connection.CreateTableAsync<Experiences>();
        }
    }
}
