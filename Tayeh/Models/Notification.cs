using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tayeh.Models
{
    public enum Reciever { Admin = 1, Lost = 2, Found = 3 };

    public class Notification
    {
        
            [Key]
            public int ID { get; set; }
            [ForeignKey("appUser")]
            public string UserId { get; set; }
            [Required(ErrorMessage = "*")]
            public Reciever reciever { get; set; }
            public string Body { get; set; }
            public DateTime Date { get; set; }
            public ApplicationUser appUser { get; set; }
        
    }
}