using Microsoft.EntityFrameworkCore;
using ServicePetShop.Domain.Entidade;
using ServicePetShop.Domain.Interfaces.Repositorio;
using ServicePetShop.Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicePetShop.Infra.Repositorio
{
    public class BaseRepositorio<T> : IBaseRepositorio<T> where T : EntidadeBase
    {

        protected readonly ServicePetShopContexto _context;
        private DbSet<T> _dataset;
        public BaseRepositorio(ServicePetShopContexto context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }

        #region DeleteAsync
        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.IdUsuario.Equals(id));
                if (result == null)
                    return false;

                _dataset.Remove(result);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region InsertAsync
        public async Task<T> InsertAsync(T item)
        {
            try
            {
                _dataset.Add(item);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }
        #endregion

        #region ExisteAsync
        public async Task<bool> ExistAsync(Guid id)
        {
            return await _dataset.AnyAsync(p => p.IdUsuario.Equals(id));
        }

        #endregion

        #region SelectAsync
        public async Task<T> SelectAsync(Guid id)
        {
            try
            {
                return await _dataset.SingleOrDefaultAsync(p => p.IdUsuario.Equals(id));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion

        #region SelectAllAsync
        public IQueryable<T> GetAll()
        {
            try
            {
                return _dataset.AsQueryable();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region UpdateAsync
        public async Task<T> UpdateAsync(T item)
        {
            try
            {
                //var result = await _dataset.FirstOrDefaultAsync(p => p.Id.Equals(item.Id));
                //if (result == null)
                //    return null;

                _context.Entry(item).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }

        #endregion
    }

}
