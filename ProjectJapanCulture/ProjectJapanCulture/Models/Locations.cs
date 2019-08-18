using SQLite;


// Defines the fields needed for a location
namespace ProjectJapanCulture.Models
{
    public class Locations
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string About { get; set; }
        public string CityName { get; set; }
        public string ThingsToDo { get; set; }
        public string Accomodation { get; set; }
        public string CityImage { get; set; }
    }
}
