using System.Collections.Generic;
using Telefonia.Data.VO;
using Telefonia.Model.Enuns;

namespace Telefonia.Business
{
    public interface IPlanoBusiness
    {
        PlanoVO Create(PlanoVO plano);
        PlanoVO FindById(long id);
        PlanoVO FindByCodigoPlano(int codigoPlano, int ddd);
        List<PlanoVO> FindByTipo(TipoPlano tipoPlano, int ddd);
        List<PlanoVO> FindByOperadora(string operadora, int ddd);
        List<PlanoVO> FindAll();
        PlanoVO Update(PlanoVO plano);
        void Delete(long id);
        PlanoVO UpdateByCodigoPlano(PlanoVO plano);
        void DeleteByCodigoPlano(int codigoPlano);
    }
}
