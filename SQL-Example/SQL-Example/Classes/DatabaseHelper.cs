using System;
using System.Collections.Generic;
using System.Linq;

namespace SQLExample.Classes
{
    public class DatabaseHelper
    {
        public DatabaseHelper()
        {
        }

        public static bool Insert<T>(ref T data, string db_path)
        {

            using (var conn = new SQLite.SQLiteConnection(db_path))
            {
                conn.CreateTable<T>();

                if (conn.Insert(data) != 0)
                    return true;
            }
                    
            return false;
        }

        public static List<Book> Read(string db_path)
        {
            List<Book> books = new List<Book>();

            using (var conn = new SQLite.SQLiteConnection(db_path))
            {
                books = conn.Table<Book>().ToList();
            }
            return books;
        }

    }
}
