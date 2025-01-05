using ServicePetShop.Domain.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePetShop.Domain.Interfaces.Repositorio
{
    public interface IBaseRepositorio<T> where T : EntidadeBase
    {
        Task<T> InsertAsync(T item);
        Task<T> UpdateAsync(T item);
        Task<bool> DeleteAsync(Guid id);
        Task<T> SelectAsync(Guid id);
        IQueryable<T> GetAll();
        Task<bool> ExistAsync(Guid id);
    }
}
