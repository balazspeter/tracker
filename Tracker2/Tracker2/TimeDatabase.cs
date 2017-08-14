using System.Linq;
using System.Collections.Generic;
using SQLite;

namespace Tracker2.PortableLibrary
{
    public class TimeDatabase
    {
        static object locker = new object();

        public SQLiteConnection database;

        public string path;

        public TimeDatabase(SQLiteConnection conn)
        {
            database = conn;
            database.CreateTable<TimeItem>();
        }

        public IEnumerable<TimeItem> GetItems()
        {
            lock (locker)
            {
                return (from i in database.Table<TimeItem>() select i).ToList();
            }
        }

        public TimeItem GetItem(int id)
        {
            lock (locker)
            {
                return database.Table<TimeItem>().FirstOrDefault(x => x.ID == id);
            }
        }

        public int SaveItem(TimeItem item)
        {
            lock (locker)
            {
                if (item.ID != 0)
                {
                    database.Update(item);
                    return item.ID;
                }
                else
                {
                    return database.Insert(item);
                }
            }
        }

        public int DeleteItem(int id)
        {
            lock (locker)
            {
                return database.Delete<TimeItem>(id);
            }
        }
    }
}