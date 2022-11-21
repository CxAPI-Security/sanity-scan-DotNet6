namespace Sanity.Models
{
    public class User
    {
        public long Id { get; set; }
        public string? Password { get; set; }
        public string? Info { get; set; }

        public string? Liame { get; set; }
        public int Height { get; set; }
    }
}