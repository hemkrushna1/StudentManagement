
using System.Linq.Expressions;

namespace StudentManagement.DataAccess.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);

        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<T> UpdateAsync(T entity);

        Task<bool> DeleteAsync(int id);

        Task<IEnumerable<T>> FindAsync(Func<T, bool> predicate);

        Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate);
    }
}
