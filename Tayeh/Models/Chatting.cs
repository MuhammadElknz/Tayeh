using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tayeh.Models
{
    public class Chatting
    {
        [Key]
        public int MID { get; set; }
        public string userSender { get; set; }
        public string userReceiver { get; set; }
        [Required]
        public string MBody { get; set; }
        public int status { get; set; }
        [Column(TypeName = "date")]
        public DateTime sentDate { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}