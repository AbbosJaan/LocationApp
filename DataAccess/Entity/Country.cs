namespace DataAccess.Entity
{
    public class Country
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public int Code { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
    }
}
