using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using WeFairAndriod.Models;

namespace WeFairAndriod.Services
{
    public class Database
    {
        readonly SQLiteConnection database;

        public Database(string dbPath)
        {
            database = new SQLiteConnection(dbPath);
            database.CreateTable<UserInfo>();
        }

        public bool InsertUser(UserInfo user)
        {
            int rowsAffected = database.Insert(user);
            return rowsAffected > 0;
        }

        public UserInfo GetUser(string username)
        {
            return database.Table<UserInfo>().FirstOrDefault(u => u.UserName == username);
        }
    }
}
