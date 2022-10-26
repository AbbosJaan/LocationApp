using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RegionRepository : IGenericRepository<Region>
    {
        private readonly AppDbContext _dbContext;
        public RegionRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Region> Create(Region region)
        {
            await _dbContext.Regions.AddAsync(region);
            await _dbContext.SaveChangesAsync();
            return region;
        }

        public async Task<bool> Delete(int id)
        {
            var region = await _dbContext.Regions.FindAsync(id);
            if (region != null)
            {
                _dbContext.Regions.Remove(region);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Region>> Get()
        {
            return await _dbContext.Regions.Include(p => p.Country).ToListAsync();
        }

        public async Task<Region> Get(int id)
        {
            return await _dbContext.Regions.FindAsync(id);
        }

        public async Task<Region> Update(int id, Region region)
        {
            var updatedRegion = _dbContext.Regions.Attach(region);
            updatedRegion.State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return region;
        }
    }
}
