using SQLite;

// Defines the fields needed for a facility phrase
namespace ProjectJapanCulture.Models
{
    public class PhrasesFacilities
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FacilityEng { get; set; }
        public string FacilityJap { get; set; }
    }
}
