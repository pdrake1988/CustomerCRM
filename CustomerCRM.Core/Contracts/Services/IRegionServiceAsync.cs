using CustomerCrm.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrm.Core.Contracts.Services
{
    public interface IRegionServiceAsync
    {
        Task<int> InsertRegion(RegionModel regionModel);
        Task<IEnumerable<RegionModel>> GetAllRegions();
        Task<int> DeleteRegionAsync(int id);
        Task<int> UpdateRegionAsync(RegionModel model);
        Task<RegionModel> GetRegionByIdAsync(int id);
    }
}
