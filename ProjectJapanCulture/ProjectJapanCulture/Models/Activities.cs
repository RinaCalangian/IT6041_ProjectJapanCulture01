using SQLite;


// Defines the fields needed for an activity
namespace ProjectJapanCulture.Models
{
    public class Activities
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string ActivityName { get; set; }
        public string AboutActivity { get; set; }
        public string ActivityLocation { get; set; }
        public string ActivityImage { get; set; }
    }
}
