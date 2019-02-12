using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCustomerApp.Models;

namespace WebApp.ModelsForSendingInUI
{
    public class ModelForMessageForSendingToUI
    {
        public Message Message;
        public List<Phone> Phones;

        ModelForMessageForSendingToUI(Message message, List<Phone> phones)
        {
            Message = message;
            Phones = phones;
        }
    }
}
