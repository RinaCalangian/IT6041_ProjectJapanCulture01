using System;

// Defines the fields needed for the MasterPage
namespace ProjectJapanCulture.Models
{
    public class MasterPageItem
    {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }

    }
}
