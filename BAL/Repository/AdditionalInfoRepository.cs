using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebCustomerApp.BAL.Interfaces;
using WebCustomerApp.Data;
using WebCustomerApp.Models;

namespace WebCustomerApp.BAL.Repository
{
    public class AdditionalInfoRepository : Repository<AdditionalInfo>, IAdditionalInfoRepository
    {
        public AdditionalInfoRepository(ApplicationDbContext sendingDbContext) : base(sendingDbContext)
        { }

        public List<AdditionalInfo> GetByPhoneId(int phoneId)
        {
            return _dbSet.Where(item => item.PhoneId == phoneId).ToList();
        }
    }
}