using DataAccess;
using DataAccess.Entity;
using LocationApp.Models;

namespace LocationApp.Services
{
    public class RegionCRUDService : IGenericCRUDService<RegionModel>
    {
        private readonly IGenericRepository<Region> _regionRepository;
        public RegionCRUDService(IGenericRepository<Region> regionRepository)
        {
            _regionRepository = regionRepository;
        }

        public async Task<RegionModel> Create(RegionModel model)
        {
            var region = new Region
            {
                Id = model.Id,
                Code = model.Code,
                Country = model.Country,
                ShortTitle = model.ShortTitle,
                Title = model.Title
            };
            var creataeRegion = await _regionRepository.Create(region);
            var result = new RegionModel
            {
                Id = creataeRegion.Id,
                Code = creataeRegion.Code,
                Country = creataeRegion.Country,
                ShortTitle = creataeRegion.ShortTitle,
                Title = creataeRegion.Title
            };
            return result;
        }

        public async Task<bool> Delete(int id)
        {
            return await _regionRepository.Delete(id);
        }

        public async Task<IEnumerable<RegionModel>> Get()
        {
            var result = new List<RegionModel>();
            var regions = await _regionRepository.Get();
            foreach (var region in regions)
            {
                var model = new RegionModel
                {
                    Id = region.Id,
                    Code = region.Code,
                    Country = region.Country,
                    ShortTitle = region.ShortTitle,
                    Title = region.Title
                };
                result.Add(model);
            }
            return result;
        }

        public async Task<RegionModel> Get(int id)
        {
            var model = await _regionRepository.Get(id);
            var result = new RegionModel
            {
                Id = model.Id,
                Code = model.Code,
                Country = model.Country,
                ShortTitle = model.ShortTitle,
                Title = model.Title
            };
            return result;
        }

        public async Task<RegionModel> Update(int id, RegionModel model)
        {
            var region = new Region
            {
                Id = model.Id,
                Code = model.Code,
                Country = model.Country,
                ShortTitle = model.ShortTitle,
                Title = model.Title
            };
            var updatedRegion = await _regionRepository.Update(id, region);
            var result = new RegionModel
            {
                Id = updatedRegion.Id,
                Country = updatedRegion.Country,
                Code = updatedRegion.Code,
                ShortTitle = updatedRegion.ShortTitle,
                Title = updatedRegion.Title
                
            };
            return result;
        }
    }
}
