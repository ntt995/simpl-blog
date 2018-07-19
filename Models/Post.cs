using System;

namespace SimplBlog.Models
{
    public class Post : BaseEntity, IBaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public string UpdateDate { get; set; }
        public string Url { get; set; }
    
    }
}
