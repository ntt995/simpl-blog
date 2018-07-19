using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplBlog.Models
{
    public class Author : BaseEntity, IBaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }        
    }
}
