using CustomerCrm.Core.Contracts.Repository;
using CustomerCrm.Core.Entities;
using CustomerCRM.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrm.Infrastructure.Repository
{
    public class ShipperRepositoryAsync : BaseRepositoryAsync<Shipper>, IRepositoryAsync<Shipper>
    {
        public ShipperRepositoryAsync(CustomerCrmDbContext _context) : base(_context)
        {
        }
    }
}
