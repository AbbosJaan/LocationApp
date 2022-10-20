using DataAccess.Entity;

namespace LocationApp.Models
{
    public class RegionCreationModel
    {
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public int Code { get; set; }
        public int CountryId { get; set; }
    }
}
