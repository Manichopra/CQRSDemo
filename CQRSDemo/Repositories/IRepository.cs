using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CQRSDemo.Repositories
{
	public interface IRepository<T> where T : class
	{
        Task<T> CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<T> GetAsync(Guid id);
        Task<IReadOnlyList<T>> GetAllAsync();
    }
}
