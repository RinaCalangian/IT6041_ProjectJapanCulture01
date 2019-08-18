using SQLite;

// Defines the fields needed for a colloquial expression
namespace ProjectJapanCulture.Models
{
    public class PhrasesExpressions
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string ExpressionEng { get; set; }
        public string ExpressionJap { get; set; }
    }
}
