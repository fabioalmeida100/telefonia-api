using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telefonia.Model;
using Telefonia.Model.Enuns;

namespace Telefonia.Business
{
    public interface IPlanoBusiness
    {
        Plano Create(Plano plano);
        Plano FindById(long id);
        Plano FindByCodigoPlano(int codigoPlano, int ddd);
        Plano FindByTipo(TipoPlano tipoPlano, int ddd);
        Plano FindByOperadora(string operadora, int ddd);
        List<Plano> FindAll();
        Plano Update(Plano plano);
        void Delete(long id);
    }
}
