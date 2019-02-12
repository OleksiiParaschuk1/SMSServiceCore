using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using WebCustomerApp.Models;
using WebCustomerApp.BAL.Interfaces;
using WebCustomerApp.Data;

namespace WebCustomerApp.BAL.Repository
{
    public class MessageRepository : Repository<Message>, IMessageRepository
    {
        public MessageRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        { }

        public List<Message> GetMessagesBySenderId(string senderId)
        {
            return _dbSet.Where(item => item.SenderId == senderId).ToList();
        }
    }
}
