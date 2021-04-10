using SQLite;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;

namespace RememberGamees.Model
{
    public class SQLiteExperiences
    {
        private SQLiteAsyncConnection _connection;

        public async Task Initialize()
        {
            if (_connection != null) return;

            _connection = new SQLiteAsyncConnection(
                Path.Combine(Xamarin.Essentials.FileSystem.AppDataDirectory, "experiences.db3"));

            await _connection.CreateTableAsync<Experiences>();
        }
    }
}
