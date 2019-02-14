using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebCustomerApp.Models
{
    public class Phone
    {
        [Key]
        public int PhoneId { get; set; }
        public string PhoneNumber { get; set; }
        public string UserId { get; set; }
        public string FullName { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public ICollection<RecepientMessage> RecepientMessages { get; set; }

        public Phone()
        {
            RecepientMessages = new List<RecepientMessage>();
        }
    }
}