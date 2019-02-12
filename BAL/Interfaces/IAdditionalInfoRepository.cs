using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WebCustomerApp.Models;

namespace WebCustomerApp.BAL.Interfaces
{
    public interface IAdditionalInfoRepository : IRepository<AdditionalInfo>
    {
        List<AdditionalInfo> GetByPhoneId(int phoneId);
    }
}
