using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telefonia.Model;

namespace Telefonia.Business
{
    public interface IPlanoBusiness
    {
        Plano Create(Plano plano);
        Plano FindById(long id);
        List<Plano> FindAll();
        Plano Update(Plano plano);
        void Delete(long id);
    }
}
