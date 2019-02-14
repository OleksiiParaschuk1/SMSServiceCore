using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCustomerApp.Models;

namespace WebCustomerApp.BAL.Interfaces
{
    public interface IUnitOfWork
    {
        UserManager<ApplicationUser> _userManager { get; }
        IMessageRepository _messageRepository { get; }
        IRecepientMessageRepository _recepientMessageRepository { get; }
        IPhoneRepository _phoneRepository { get; }

        void SaveChanges();
    }
}
