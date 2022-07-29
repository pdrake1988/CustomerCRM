using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrm.Core.Contracts.Repository
{
    public interface IRepositoryAsync<T>  where T : class
    {
        Task<int> InsertAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteAsync(T entity);
        Task<T> GetByIdAsync(T entity);
        Task<IEnumerable<T>> DeleteAllAsync();
    }
}
