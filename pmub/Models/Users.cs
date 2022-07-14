using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace pmub.Models
{
    [Table("Users")]
    public class Users
    {
        [PrimaryKey, AutoIncrement]
        public int IdUsers { get; set; }
        [MaxLength(100), Unique]
        public string User{ get; set; }
        [MaxLength(100)]
        public string UsersName { get; set; }

        [MaxLength(100)]
        public string UsersPrenoms { get; set; }
        public string UsersTel { get; set; }
        
        public string UsersPass { get; set; }
    }
}
