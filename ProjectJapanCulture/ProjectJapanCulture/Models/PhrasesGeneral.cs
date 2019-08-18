﻿using SQLite;

// Defines the fields needed for a general phrase
namespace ProjectJapanCulture.Models
{
    public class PhrasesGeneral
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string GeneralEng { get; set; }
        public string GeneralJap { get; set; }
    }
}
