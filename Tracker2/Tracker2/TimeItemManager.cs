using System.Collections.Generic;
using SQLite;

namespace Tracker2.PortableLibrary
{
    public class TimeItemManager
    {
        TimeItemRepository repository;

        public TimeItemManager(SQLiteConnection conn)
        {
            repository = new TimeItemRepository(conn);
        }

        public TimeItem GetTime(int id)
        {
            return repository.GetTime(id);
        }

        public IList<TimeItem> GetTimes()
        {
            return new List<TimeItem>(repository.GetTimes());
        }

        public int SaveTime(TimeItem item)
        {
            return repository.SaveTime(item);
        }

        public int DeleteTime(int id)
        {
            return repository.DeleteTime(id);
        }
    }
}