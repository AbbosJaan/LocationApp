using DataAccess;
using DataAccess.Entity;
using LocationApp.Models;

namespace LocationApp.Services
{
    public class CountryCRUDService : IGenericCRUDService<CountryCreationModel, CountryResponseModel>
    {
        private readonly IGenericRepository<Country> _countryRepository;
        public CountryCRUDService(IGenericRepository<Country> countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public async Task<CountryResponseModel> Create(CountryCreationModel model)
        {
            var country = new Country
            {
                Code = model.Code,
                ShortTitle = model.ShortTitle,
                Title = model.Title
            };
            var creataeCountry = await _countryRepository.Create(country);
            var result = new CountryResponseModel
            {
                Code = creataeCountry.Code,
                ShortTitle = creataeCountry.ShortTitle,
                Title = creataeCountry.Title,
                Id = creataeCountry.Id
            };
            return result;
        }

        public async Task<bool> Delete(int id)
        {
            return await _countryRepository.Delete(id);
        }

        public async Task<IEnumerable<CountryResponseModel>> Get()
        {
            var result = new List<CountryResponseModel>();
            var countrys = await _countryRepository.Get();
            foreach (var country in countrys)
            {
                var model = new CountryResponseModel
                {
                    Id = country.Id,
                    Code = country.Code,
                    ShortTitle = country.ShortTitle,
                    Title = country.Title
                    //Regions = country.Regions
                };
                result.Add(model);
            }
            return result;
        }

        public async Task<CountryResponseModel> Get(int id)
        {
            var model = await _countryRepository.Get(id);
            var result = new CountryResponseModel
            {
                Id = model.Id,
                Code = model.Code,
                ShortTitle = model.ShortTitle,
                Title = model.Title,
                //Regions = model.Regions
            };
            return result;
        }

        public async Task<CountryResponseModel> Update(int id, CountryCreationModel model)
        {
            var country = new Country
            {
                Id = id,
                Code = model.Code,
                ShortTitle = model.ShortTitle,
                Title = model.Title
            };
            var updatedCountry = await _countryRepository.Update(id, country);
            var result = new CountryResponseModel
            {
                Id = updatedCountry.Id,
                Code = updatedCountry.Code,
                ShortTitle = updatedCountry.ShortTitle,
                Title = updatedCountry.Title

            };
            return result;
        }
    }
}
