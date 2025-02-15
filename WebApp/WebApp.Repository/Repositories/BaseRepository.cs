﻿using WebApp.Repository.Repositories.Interfaces;

namespace WebApp.Repository.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public BaseRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task Add(T entity)
        {
            _applicationDbContext.Add(entity);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            _applicationDbContext.Remove(entity);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task<T?> Get(int id)
        {
            var entity = await _applicationDbContext.FindAsync<T>(id);
            return entity;   
        }

        public Task<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
