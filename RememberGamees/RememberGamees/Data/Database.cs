using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace RememberGamees.Data
{
    public class Database
    {
        static SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            CreateDb(dbPath);
        }

        public async void CreateDb(string dbPath)
        {
            //adfaf
            _database = new SQLiteAsyncConnection(dbPath);
            await _database.DeleteAllAsync<ScoreOfReaction>();
            await _database.DeleteAllAsync<ScoreOfMemory>();
        }
        //adfafa
        public Task<List<ScoreOfReaction>> GetScoreOfReactionAsync()
        {
            return _database.Table<ScoreOfReaction>().ToListAsync();
        }

        public Task<int> SaveScoreOfReactionAsync(ScoreOfReaction scoreOfReaction)
        {
            return _database.InsertAsync(scoreOfReaction);
        }

        //adfa
        public Task<List<ScoreOfMemory>> GetScoreOfMemoryAsync()
        {
            return _database.Table<ScoreOfMemory>().ToListAsync();
        }

        public Task<int> SaveScoreOfMemoryAsync(ScoreOfMemory scoreOfMemory)
        {
            return _database.InsertAsync(scoreOfMemory);
        }
    }
}
