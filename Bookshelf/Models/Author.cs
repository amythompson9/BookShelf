using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookshelf.Models
{
    public class Author
    {
        [Key]
        public string ID { get; set; }
        public string LastFirst { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
    }
}