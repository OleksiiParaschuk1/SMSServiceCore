using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WebCustomerApp.Models;

namespace WebCustomerApp.BAL.Interfaces
{
    public interface IRecepientMessageRepository : IRepository<RecepientMessage>
    {
        List<RecepientMessage> GetRecepientsMessagesByMessageId(int messageId);
        List<RecepientMessage> GetRecepientsMessagesByRecipientId(int messageId);
    }
}
