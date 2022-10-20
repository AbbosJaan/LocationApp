namespace LocationApp.Services
{
    public interface IGenericCRUDService<T, Ttwo> where T : class
    {
        Task<IEnumerable<Ttwo>> Get();
        Task<Ttwo> Create(T model);
        Task<Ttwo> Get(int id);
        Task<Ttwo> Update(int id, T model);
        Task<bool> Delete(int id);
    }
}
