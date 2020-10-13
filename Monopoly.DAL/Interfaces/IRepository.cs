namespace Monopoly.DAL.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using Monopoly.DAL.Entities.BaseEntities;

    public interface IRepository
    {
        IEnumerable<T> GetByFilter<T>(bool tracking, Func<T, bool> predicate, params Expression<Func<T, object>>[] includeProperties)
            where T : BaseDto;

        T GetExemplarByFilter<T>(bool tracking, Func<T, bool> predicate, params Expression<Func<T, object>>[] includeProperties)
            where T : BaseDto;

        T AddExemplar<T>(T exemplar)
            where T : BaseDto;

        void DeleteByFilter<T>(Func<T, bool> predicate, params Expression<Func<T, object>>[] includeProperties)
            where T : BaseDto;

        void UpdateExemplar<T>(T exemplar)
            where T : BaseDto;

        Task<IEnumerable<T>> GetByFilterAsync<T>(bool tracking, Func<T, bool> predicate, params Expression<Func<T, object>>[] includeProperties)
            where T : BaseDto;

        Task<T> GetExemplarByFilterAsync<T>(bool tracking, Func<T, bool> predicate, params Expression<Func<T, object>>[] includeProperties)
            where T : BaseDto;

        Task<T> AddExemplarAsync<T>(T exemplar)
            where T : BaseDto;

        Task DeleteByFilterAsync<T>(Func<T, bool> predicate, params Expression<Func<T, object>>[] includeProperties)
            where T : BaseDto;

        Task UpdateExemplarAsync<T>(T exemplar)
            where T : BaseDto;
    }
}