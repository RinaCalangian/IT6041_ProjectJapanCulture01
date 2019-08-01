using SQLite;

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
