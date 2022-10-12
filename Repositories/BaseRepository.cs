using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cineweb_orders_api.Repositories
{
    public abstract class BaseRepository<T> where T : class
    {
        protected abstract void Save(T entity);

        protected abstract void Update(T entity);

        protected abstract void Delete(string email);

        protected abstract T FindById(int Id);

        protected abstract List<T> FindAll();

        protected abstract T FindByEmail(string email);
        protected abstract T FindByPassword(string password);
    }
}
