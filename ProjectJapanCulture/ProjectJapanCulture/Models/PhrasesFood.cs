using SQLite;

// Defines the fields needed for a food phrase
namespace ProjectJapanCulture.Models
{
    public class PhrasesFood
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FoodEng { get; set; }
        public string FoodJap { get; set; }
    }
}
