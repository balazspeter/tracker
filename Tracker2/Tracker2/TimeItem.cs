using SQLite;

namespace Tracker2.PortableLibrary
{
    public class TimeItem
    {
        public TimeItem()
        {
        }

        // SQLite attributes
        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }
        public int StartTimestamp { get; set; }
        public int EndTimestamp { get; set; }
    }
}