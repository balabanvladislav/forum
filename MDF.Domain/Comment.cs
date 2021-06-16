using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MDForum.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Author { get; set; }

        public string CommentText { get; set; }

        public string DTime { set; get; }

        public int ThemeId{ get; set; }

        public virtual ApplicationUser User { set; get; }
    }
}