using DataAccess;
using DataAccess.Entity;
using LocationApp.Models;

namespace LocationApp.Services
{
    public class CountryCRUDService : IGenericCRUDService<CountryModel>
    {
        private readonly IGenericRepository<Country> _countryRepository;
        public CountryCRUDService(IGenericRepository<Country> countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public async Task<CountryModel> Create(CountryModel model)
        {
            var country = new Country
            {
                Id = model.Id,
                Code = model.Code,
                ShortTitle = model.ShortTitle,
                Title = model.Title
            };
            var creataeCountry = await _countryRepository.Create(country);
            var result = new CountryModel
            {
                Id = creataeCountry.Id,
                Code = creataeCountry.Code,
                ShortTitle = creataeCountry.ShortTitle,
                Title = creataeCountry.Title
            };
            return result;
        }

        public async Task<bool> Delete(int id)
        {
            return await _countryRepository.Delete(id);
        }

        public async Task<IEnumerable<CountryModel>> Get()
        {
            var result = new List<CountryModel>();
            var countrys = await _countryRepository.Get();
            foreach (var country in countrys)
            {
                var model = new CountryModel
                {
                    Id = country.Id,
                    Code = country.Code,
                    ShortTitle = country.ShortTitle,
                    Title = country.Title
                };
                result.Add(model);
            }
            return result;
        }

        public async Task<CountryModel> Get(int id)
        {
            var model = await _countryRepository.Get(id);
            var result = new CountryModel
            {
                Id = model.Id,
                Code = model.Code,
                ShortTitle = model.ShortTitle,
                Title = model.Title
            };
            return result;
        }

        public async Task<CountryModel> Update(int id, CountryModel model)
        {
            var country = new Country
            {
                Id = model.Id,
                Code = model.Code,
                ShortTitle = model.ShortTitle,
                Title = model.Title
            };
            var updatedCountry = await _countryRepository.Update(id, country);
            var result = new CountryModel
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
