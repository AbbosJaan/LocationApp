namespace DataAccess.Entity
{
    public class Region
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public virtual Country Country { get; set; }
        public int Code { get; set; }
        public int CountryId { get; set; }
    }
}
