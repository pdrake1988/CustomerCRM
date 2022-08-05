using CustomerCrm.Core.Contracts.Repository;
using CustomerCrm.Core.Contracts.Services;
using CustomerCrm.Core.Entities;
using CustomerCrm.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrm.Infrastructure.Service
{
    public class CustomerServiceAsync : ICustomerServiceAsync
    {
        ICustomerRepositoryAsync customerRepositoryAsync;
        IRegionRepositoryAsync regionRepositoryAsync;
        public CustomerServiceAsync(ICustomerRepositoryAsync _repo, IRegionRepositoryAsync _region)
        {
            customerRepositoryAsync = _repo;
            regionRepositoryAsync = _region;
        }

        public async Task<IEnumerable<CustomerReponseModel>> GetAllAsync()
        {
            var customers = await customerRepositoryAsync.GetAllAsync();
            if (customers != null)
            {
                List<CustomerReponseModel> lstCustomers = new List<CustomerReponseModel>();
                foreach (var c in customers)
                {
                    CustomerReponseModel model = new CustomerReponseModel();
                    model.Id = c.Id;
                    model.Name = c.Name;
                    model.Phone = c.Phone;
                    model.Address = c.Address;
                    model.City = c.City;
                    model.Title = c.Title;
                    model.Country = c.Country;
                    model.RegionId = c.RegionId;
                    model.PostalCode = c.PostalCode;
                    var region = await regionRepositoryAsync.GetByIdAsync(c.RegionId);
                    model.RegionName = region.Name;
                    lstCustomers.Add(model);
                }
                return lstCustomers;
            }
            return null;
        }

        public async Task<CustomerReponseModel> GetCustomerByIdAsync(int id)
        {
            Customer c = await customerRepositoryAsync.GetByIdAsync(id);
            if (c != null)
            {
                CustomerReponseModel model = new CustomerReponseModel();
                model.Id = c.Id;
                model.Name = c.Name;
                model.Phone = c.Phone;
                model.Address = c.Address;
                model.City = c.City;
                model.Title = c.Title;
                model.Country = c.Country;
                model.RegionId = c.RegionId;
                model.PostalCode = c.PostalCode;
                var region = await regionRepositoryAsync.GetByIdAsync(c.RegionId);
                model.RegionName = region.Name;

                return model;
            }
            return null;
        }

        public Task<int> InsertCustomerAsync(CustomerModel model)
        {
            Customer customer = new Customer()
            {

                Name = model.Name,
                Title = model.Title,
                Address = model.Address,
                City = model.City,
                Country = model.Country,
                Phone = model.Phone,
                PostalCode = model.PostalCode,
                RegionId = model.RegionId

            };
            return customerRepositoryAsync.InsertAsync(customer);
        }
    }
}
