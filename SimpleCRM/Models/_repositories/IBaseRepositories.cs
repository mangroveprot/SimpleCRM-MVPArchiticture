using System.Collections.Generic;

namespace SimpleCRM.Models._repositories
{
    public interface IBaseRepository<T>
    {
        void Add(T entity);
        void Edit(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetByValue(string value);
    }
}
