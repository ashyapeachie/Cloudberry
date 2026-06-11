namespace Cloudberry.Models
{
    public class MoodEntry
    {
        public int Id {get; set;}
        public string Mood {get; set;} = string.Empty;
        public string? Note {get; set;}
        public DateTime DateCreated {get; set;} = DateTime.Now;
    }
}
