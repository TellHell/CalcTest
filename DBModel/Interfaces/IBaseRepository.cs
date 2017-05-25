using System.Collections.Generic;

namespace WebCalc.Managers
{

    //Базовый итерфейс хранилища данных

    public interface IBaseRepository<T> where T : class
    {
        T Load(long id);

        void Save(T entity);

        void Update(T entity);

        IEnumerable<T> GetAll();

        IEnumerable<T> GetAll(bool flag);

        void Delet(T entity);
    }
}
