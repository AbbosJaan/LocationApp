using DataAccess.Entity;

namespace LocationApp.Models
{
    public class RegionResponseModel : RegionCreationModel
    {
        public int Id { get; set; }
        public string Country { get; set; }
    }
}
