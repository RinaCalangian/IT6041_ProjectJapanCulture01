using SQLite;

// Defines the fields needed for a time phrase
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
