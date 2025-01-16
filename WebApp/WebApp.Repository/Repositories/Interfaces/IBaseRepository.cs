namespace WebApp.Repository.Repositories.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task<T> Get(T entity);
        Task<T> GetAll();

    }
}
