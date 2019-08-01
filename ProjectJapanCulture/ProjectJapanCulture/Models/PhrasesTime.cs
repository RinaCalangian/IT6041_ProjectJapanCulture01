using SQLite;

namespace ProjectJapanCulture.Models
{
    public class PhrasesTime
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string TimeEng { get; set; }
        public string TimeJap { get; set; }
    }
}
