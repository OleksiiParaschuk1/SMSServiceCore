using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCustomerApp.Models.MessageViewModels
{
    public class MessageModel
    {
        [Required]
        public string TextOfMessage { get; set; }
    }
}
