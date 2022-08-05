using CustomerCrm.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrm.Core.Contracts.Services
{
    public interface ICustomerServiceAsync
    {
        Task<int> InsertCustomerAsync(CustomerModel model);
        Task<CustomerReponseModel> GetCustomerByIdAsync(int id);
        Task<IEnumerable<CustomerReponseModel>> GetAllAsync();
    }
}
