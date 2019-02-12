using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCustomerApp.BAL.Interfaces;
using WebCustomerApp.Data;
using WebCustomerApp.Models;

namespace WebCustomerApp.BAL.Repository
{
    public class RecepientMessageRepository : Repository<RecepientMessage>, IRecepientMessageRepository
    {
        public RecepientMessageRepository(ApplicationDbContext sendingDbContext) : base(sendingDbContext)
        { }

        public List<RecepientMessage> GetRecepientsMessagesByMessageId(int messageId)
        {
            return _dbSet.Where(item => item.MessageId == messageId).ToList();
        }
        public List<RecepientMessage> GetRecepientsMessagesByRecipientId(int recipientId)
        {
            return _dbSet.Where(item => item.PhoneId == recipientId).ToList();
        }
    }
}
