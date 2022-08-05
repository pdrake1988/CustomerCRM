using CustomerCrm.Core.Contracts.Repository;
using CustomerCrm.Core.Contracts.Services;
using CustomerCrm.Core.Entities;
using CustomerCrm.Core.Models;
using CustomerCrm.Infrastructure.Repository;
using CustomerCRM.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrm.Infrastructure.Service
{
    public class EmployeeServiceAsync : IEmployeeServiceAsync
    {
        IEmployeeRepositoryAsync employee;

        public EmployeeServiceAsync(IEmployeeRepositoryAsync _employee)
        {
            employee = _employee;
        }

        public async Task<IEnumerable<EmployeeModel>> GetAllEmployeesAsync()
        {
            var employees = await employee.GetAllAsync();
            if (employees != null)
            {
                List<EmployeeModel> result = new List<EmployeeModel>();
                foreach (var employee in employees)
                {
                    EmployeeModel employeeModel = new EmployeeModel();
                    employeeModel.Id = employee.Id;
                    employeeModel.Address = employee.Address;
                    employeeModel.FirstName = employee.FirstName;
                    employeeModel.LastName = employee.LastName;
                    employeeModel.BirthDate = employee.BirthDate;
                    employeeModel.City = employee.City;
                    employeeModel.Country = employee.Country;
                    employeeModel.Phone = employee.Phone;
                    employeeModel.PhotoPath = employee.PhotoPath;
                    employeeModel.PostalCode = employee.PostalCode;
                    result.Add(employeeModel);
                }
                return result;
            }
            return null;
        }

        public async Task<EmployeeModel> GetEmployeeByIdAsync(int id)
        {
            var emp = await employee.GetByIdAsync(id);
            if (emp != null)
            {
                EmployeeModel model = new EmployeeModel();
                model.Id = emp.Id;
                model.Address = emp.Address;
                model.FirstName = emp.FirstName;
                model.LastName = emp.LastName;
                model.BirthDate = emp.BirthDate;
                model.City = emp.City;
                model.Country = emp.Country;
                model.Phone = emp.Phone;
                model.PhotoPath = emp.PhotoPath;
                model.PostalCode = emp.PostalCode;
                return model;
            }
            return null;
        }

        public Task<int> InsertEmployeeAsync(EmployeeModel model)
        {
            Employee emp = new Employee()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Title = model.Title,
                BirthDate = model.BirthDate,
                Address = model.Address,
                City = model.City,
                RegionId = model.RegionId,
                Country = model.Country,
                Phone = model.Phone,
                PhotoPath = model.PhotoPath,
                PostalCode = model.PostalCode,
            };
            return employee.InsertAsync(emp);
        }
    }
}
