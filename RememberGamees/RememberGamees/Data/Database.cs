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
            //conection
            _database = new SQLiteAsyncConnection(dbPath);
            //TABLE FOR REACTION GAME
            await _database.CreateTableAsync<ScoreOfReaction>();
            //TABLE FOR MEMORY GAME
            await _database.CreateTableAsync<ScoreOfMemory>();
            //TABLE FOR MATH GAME
            await _database.CreateTableAsync<ScoreOfMath>();
        }
        //SAVE AND RETRIVE EXPERIENCE FOR REACTION GAME
        public Task<List<ScoreOfReaction>> GetScoreOfReactionAsync()
        {
            return _database.Table<ScoreOfReaction>().ToListAsync();
        }

        public Task<int> SaveScoreOfReactionAsync(ScoreOfReaction scoreOfReaction)
        {
            return _database.InsertAsync(scoreOfReaction);
        }

        //SAVE AND RETRIVE EXPERIENCE FOR MEMORY GAME
        public Task<List<ScoreOfMemory>> GetScoreOfMemoryAsync()
        {
            return _database.Table<ScoreOfMemory>().ToListAsync();
        }

        public Task<int> SaveScoreOfMemoryAsync(ScoreOfMemory scoreOfMemory)
        {
            return _database.InsertAsync(scoreOfMemory);
        }
        //SAVE AND RETRIVE EXPERIENCE FOR MATH GAME
        public Task<List<ScoreOfMath>> GetScoreOfMathAsync()
        {
            return _database.Table<ScoreOfMath>().ToListAsync();
        }

        public Task<int> SaveScoreOfMathAsync(ScoreOfMath scoreOfMath)
        {
            return _database.InsertAsync(scoreOfMath);
        }
    }
}
