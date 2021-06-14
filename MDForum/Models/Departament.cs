namespace MDForum.Models
{
    public class Departament
    {
        public int Id { get; set; }
        
        public int Category { get; set; }
        
        public int CategoryId { get; set; }
        
        public string Title { get; set; }

        public string DepText { get; set; }
        
        public virtual ApplicationUser User { set; get; }
    }
}