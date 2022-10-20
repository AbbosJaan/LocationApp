using DataAccess;
using DataAccess.Entity;
using LocationApp.Models;

namespace LocationApp.Services
{
    public class RegionCRUDService : IGenericCRUDService<RegionCreationModel, RegionResponseModel>
    {
        private readonly IGenericRepository<Region> _regionRepository;
        private readonly IGenericRepository<Country> _countryRepository;
        public RegionCRUDService(IGenericRepository<Region> regionRepository, IGenericRepository<Country> countryRepository)
        {
            _regionRepository = regionRepository;
            _countryRepository = countryRepository;
        }

        public async Task<RegionResponseModel> Create(RegionCreationModel model)
        {
            var region = new Region
            {
                Code = model.Code,
                ShortTitle = model.ShortTitle,
                Title = model.Title,
                CountryId = model.CountryId,
            };
            var creataeRegion = await _regionRepository.Create(region);
            var result = new RegionResponseModel
            {
                Id = creataeRegion.Id,
                Code = creataeRegion.Code,
                ShortTitle = creataeRegion.ShortTitle,
                Title = creataeRegion.Title,
                CountryId = creataeRegion.CountryId,
                Country = nameof(creataeRegion.Country)
            };
            return result;
        }

        public async Task<bool> Delete(int id)
        {
            return await _regionRepository.Delete(id);
        }

        public async Task<IEnumerable<RegionResponseModel>> Get()
        {
            var result = new List<RegionResponseModel>();
            var regions = await _regionRepository.Get();
            foreach (var region in regions)
            {
                var country = await _countryRepository.Get(region.CountryId);
                var model = new RegionResponseModel
                {
                    Id = region.Id,
                    Code = region.Code,
                    Country = country.Title,
                    CountryId = region.CountryId,
                    ShortTitle = region.ShortTitle,
                    Title = region.Title
                };
                result.Add(model);
            }
            return result;
        }

        public async Task<RegionResponseModel> Get(int id)
        {
            var model = await _regionRepository.Get(id);
            var country =await _countryRepository.Get(model.CountryId);
            var result = new RegionResponseModel
            {
                Id = model.Id,
                Code = model.Code,
                CountryId = model.CountryId,
                Country = country.Title,
                ShortTitle = model.ShortTitle,
                Title = model.Title
            };
            return result;
        }

        public async Task<RegionResponseModel> Update(int id, RegionCreationModel model)
        {
            var region = new Region
            {
                Id = id,
                Code = model.Code,
                CountryId = model.CountryId,
                ShortTitle = model.ShortTitle,
                Title = model.Title
                };
            var updatedRegion = await _regionRepository.Update(id, region);
            var result = new RegionResponseModel
            {
                Id = updatedRegion.Id,
                Country = nameof(updatedRegion.Title),
                CountryId = updatedRegion.CountryId,
                Code = updatedRegion.Code,
                ShortTitle = updatedRegion.ShortTitle,
                Title = updatedRegion.Title
                
            };
            return result;
        }
    }
}
