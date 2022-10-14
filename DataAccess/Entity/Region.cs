namespace DataAccess.Entity
{
    public class Region
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public Country Country { get; set; }
        public int Code { get; set; }
    }
}
