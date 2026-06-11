namespace Cloudberry.Models
{
    public class JournalEntry
    {
        public int Id {get; set;}
        public string Title {get; set;} = string.Empty;
        public string Content {get; set;} = string.Empty;
        public DateTime DateCreated {get; set;} = DateTime.Now;
    }
}
