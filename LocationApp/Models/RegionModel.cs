using DataAccess.Entity;

namespace LocationApp.Models
{
    public class RegionModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public Country Country { get; set; }
        public int Code { get; set; }
    }
}
