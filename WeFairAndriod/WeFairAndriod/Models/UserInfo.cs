using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeFairAndriod.Models
{
    public class UserInfo
    {
        [PrimaryKey, AutoIncrement] 
        public int Id { get; set; }

        [Unique]
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
