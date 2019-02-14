using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebCustomerApp.BAL.Interfaces;
using WebCustomerApp.Data;
using WebCustomerApp.Models;

namespace WebCustomerApp.BAL.Repository
{
    public class PhoneRepository : Repository<Phone>, IPhoneRepository
    {
        public PhoneRepository(ApplicationDbContext sendingDbContext) : base(sendingDbContext)
        { }

        public List<Phone> GetPhonesByUserId(string userId)
        {
            return _dbSet.Where(item => item.UserId == userId).ToList();
        }
    }
}