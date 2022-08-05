using CustomerCrm.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrm.Core.Contracts.Services
{
    public interface IEmployeeServiceAsync
    {
        Task<int> InsertEmployeeAsync(EmployeeModel model);
        Task<EmployeeModel> GetEmployeeByIdAsync(int id);
        Task<IEnumerable<EmployeeModel>> GetAllEmployeesAsync();
    }
}
