using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tayeh.Models
{
    public class LostChildPosts
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public string LostLocation { get; set; }
        public byte[] Image { get; set; }
        [ForeignKey("Users")]
        public string  UserId { get; set; }
        public virtual ApplicationUser Users { get; set; }
        
    }
}