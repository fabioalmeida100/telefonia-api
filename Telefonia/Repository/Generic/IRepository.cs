using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telefonia.Model.Base;

namespace Telefonia.Repository.Generic
{
    public interface IRepository<T> where T: BaseEntity
    {
        T Create(T T);
        T FindById(long id);
        List<T> FindAll();
        T Update(T T);
        void Delete(long id);

    }
}
