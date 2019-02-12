using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WebCustomerApp.Models;

namespace WebCustomerApp.BAL.Interfaces
{
    public interface IMessageRepository : IRepository<Message>
    {
        List<Message> GetMessagesBySenderId(string senderId);
    }
}
