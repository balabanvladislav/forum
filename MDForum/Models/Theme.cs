namespace MDForum.Models
{
    public class Theme
    {
        public int Id { get; set; }

        public int Category { get; set; }
        public string Title { get; set; }

        public string DepText { get; set; }

        public virtual ApplicationUser User { set; get; }
    }
}