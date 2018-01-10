using System;
using SQLite;

namespace SQLExample.Classes
{
    public class Book
    {
        public Book()
        {
        }

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
