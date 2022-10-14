using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CountryRepository : IGenericRepository<Country>
    {
        private readonly AppDbContext _dbContext;

        public CountryRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Country> Create(Country elemnt)
        {
            await _dbContext.Countries.AddAsync(elemnt);
            await _dbContext.SaveChangesAsync();
            return elemnt;
        }

        public async Task<bool> Delete(int id)
        {
            var country = await _dbContext.Countries.FindAsync(id);
            if (country != null)
            {
                _dbContext.Countries.Remove(country);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Country>> Get()
        {
            return await _dbContext.Countries.ToListAsync();
        }

        public async Task<Country> Get(int id)
        {
            return await _dbContext.Countries.FindAsync(id);
        }

        public async Task<Country> Update(int id, Country country)
        {
            var updatedCountry = _dbContext.Countries.Attach(country);
            updatedCountry.State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return country;
        }
    }
}
