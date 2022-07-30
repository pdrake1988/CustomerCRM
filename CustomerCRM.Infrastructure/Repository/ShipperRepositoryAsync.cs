using CustomerCrm.Core.Contracts.Repository;
using CustomerCrm.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrm.Infrastructure.Repository
{
    internal class ShipperRepositoryAsync : IRepositoryAsync<Shipper>
    {
        public Task<int> DeleteAsync(Shipper entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Shipper>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Shipper> GetByIdAsync(Shipper entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(Shipper entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Shipper entity)
        {
            throw new NotImplementedException();
        }
    }
}
