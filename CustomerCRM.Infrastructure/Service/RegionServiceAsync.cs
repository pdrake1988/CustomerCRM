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
    internal class RegionServiceAsync : IRegionServiceAsync
    {
        IRegionRepositoryAsync regionRepository;
        public RegionServiceAsync(IRegionRepositoryAsync _regionRepository)
        {
            regionRepository = _regionRepository;
        }
        public async Task<int> InsertRegion(RegionModel regionModel)
        {
            Region regionEntity = new Region();
            regionEntity.Name = regionModel.Name;
            return await regionRepository.InsertAsync(regionEntity);

        }

        public async Task<IEnumerable<RegionModel>> GetAllRegions()
        {
            var result = await regionRepository.GetAllAsync();

            List<RegionModel> regions = new List<RegionModel>();
            if (result != null)
            {
                foreach (var item in result)
                {
                    RegionModel r = new RegionModel();
                    r.Id = item.Id;
                    r.Name = item.Name;
                    regions.Add(r);
                }
            }
            return regions;
        }

        public async Task<int> DeleteRegionAsync(int id)
        {
            return await regionRepository.DeleteAsync(id);
        }
    }
}
