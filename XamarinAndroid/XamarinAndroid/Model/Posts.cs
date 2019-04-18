using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinAndroid.Model
{
    public class Posts
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(250)]
        public string Experience { get; set; }
    }
}
