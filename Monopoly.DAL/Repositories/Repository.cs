namespace Monopoly.DAL.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Monopoly.DAL.Entities.BaseEntities;
    using Monopoly.DAL.Interfaces;

    public class Repository : IRepository
    {
        private readonly AppDbContext dbContext;

        public Repository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<T> GetByFilter<T>(bool tracking, Func<T, bool> predicate, params Expression<Func<T, object>>[] includeProperties)
            where T : BaseDto
        {
            var query = this.Include(tracking, includeProperties);
            return query.Where(predicate);
        }

        public T GetExemplarByFilter<T>(bool tracking, Func<T, bool> predicate, params Expression<Func<T, object>>[] includeProperties)
            where T : BaseDto
        {
            var query = this.Include(tracking, includeProperties);
            return query.AsEnumerable().Where(e => predicate(e)).FirstOrDefault();
        }

        public T AddExemplar<T>(T exemplar)
            where T : BaseDto
        {
            T newExemplar = this.dbContext.Set<T>().Add(exemplar).Entity;
            this.dbContext.SaveChanges();
            return newExemplar;
        }

        public void DeleteByFilter<T>(Func<T, bool> predicate, params Expression<Func<T, object>>[] includeProperties)
            where T : BaseDto
        {
            this.dbContext.Set<T>().RemoveRange(this.GetByFilter<T>(false, predicate, includeProperties));
            this.dbContext.SaveChanges();
        }

        public void UpdateExemplar<T>(T exemplar)
            where T : BaseDto
        {
            this.dbContext.Set<T>().Update(exemplar);
            this.dbContext.SaveChanges();
        }

        public async Task<IEnumerable<T>> GetByFilterAsync<T>(bool tracking, Func<T, bool> predicate, params Expression<Func<T, object>>[] includeProperties)
            where T : BaseDto
        {
            var query = await this.Include(tracking, includeProperties).ToListAsync();
            return query.Where(predicate);
        }

        public async Task<T> GetExemplarByFilterAsync<T>(bool tracking, Func<T, bool> predicate, params Expression<Func<T, object>>[] includeProperties)
            where T : BaseDto
        {
            var query = await this.Include(tracking, includeProperties).ToListAsync();
            return query.FirstOrDefault(predicate);
        }

        public async Task<T> AddExemplarAsync<T>(T exemplar)
            where T : BaseDto
        {
            var newExemplarTask = await this.dbContext.Set<T>().AddAsync(exemplar);
            await this.dbContext.SaveChangesAsync();
            return newExemplarTask.Entity;
        }

        public Task DeleteByFilterAsync<T>(Func<T, bool> predicate, params Expression<Func<T, object>>[] includeProperties)
            where T : BaseDto
        {
            this.dbContext.Set<T>().RemoveRange(this.GetByFilter<T>(false, predicate, includeProperties));
            return this.dbContext.SaveChangesAsync();
        }

        public Task UpdateExemplarAsync<T>(T exemplar)
            where T : BaseDto
        {
            this.dbContext.Set<T>().Update(exemplar);
            return this.dbContext.SaveChangesAsync();
        }

        private IQueryable<T> Include<T>(bool tracking, params Expression<Func<T, object>>[] includeProperties)
            where T : BaseDto
        {
            if (tracking)
            {
                IQueryable<T> query = this.dbContext.Set<T>();
                return includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            }
            else
            {
                IQueryable<T> query = this.dbContext.Set<T>().AsNoTracking();
                return includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            }
        }
    }
}