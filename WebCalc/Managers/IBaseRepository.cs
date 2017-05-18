using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCalc.Managers
{

    //Базовый итерфейс хранилища данных

    public interface IBaseRepository<T> where T : class
    {
        T Load(long id);

        void Save(T entity);

        void Update(T entity);

        IEnumerable<T> GetAll();


    }
}
