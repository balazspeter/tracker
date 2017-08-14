using System.Collections.Generic;
using SQLite;

namespace Tracker2.PortableLibrary
{
    public class TimeItemRepository
    {
        TimeDatabase db = null;

        public TimeItemRepository(SQLiteConnection conn)
        {
            db = new TimeDatabase(conn);
        }

        public TimeItem GetTime(int id)
        {
            return db.GetItem(id);
        }

        public IEnumerable<TimeItem> GetTimes()
        {
            return db.GetItems();
        }

        public int SaveTime(TimeItem item)
        {
            return db.SaveItem(item);
        }

        public int DeleteTime(int id)
        {
            return db.DeleteItem(id);
        }
    }
}

