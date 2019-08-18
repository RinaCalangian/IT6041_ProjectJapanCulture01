using SQLite;

// Defines the fields needed for an accommodation phrase
namespace ProjectJapanCulture.Models
{
    public class PhrasesAccomodation
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string AccomodationEng { get; set; }
        public string AccomodationJap { get; set; }
    }
}
