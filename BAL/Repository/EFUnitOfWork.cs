using Microsoft.AspNetCore.Identity;
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
    public class EFUnitOfWork : IUnitOfWork
    {
        public UserManager<ApplicationUser> _userManager { get; }
        public IMessageRepository _messageRepository { get; }
        public IRecepientMessageRepository _recepientMessageRepository { get; }
        public IPhoneRepository _phoneRepository { get; }


        public EFUnitOfWork(UserManager<ApplicationUser> userManager, IMessageRepository messageRepository, IRecepientMessageRepository recepientMessageRepository,
            IPhoneRepository phoneRepository)
        {
            _userManager = userManager;
            _messageRepository = messageRepository;
            _recepientMessageRepository = recepientMessageRepository;
            _phoneRepository = phoneRepository;
        }

        public void SaveChanges()
        {
            _messageRepository.SaveChanges();
            _recepientMessageRepository.SaveChanges();
            _phoneRepository.SaveChanges();
        }
    }
}
