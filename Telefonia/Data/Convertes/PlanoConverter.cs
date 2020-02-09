using System.Collections.Generic;
using System.Linq;
using Telefonia.Data.Converter;
using Telefonia.Data.VO;
using Telefonia.Model;

namespace Telefonia.Data.Convertes
{
    public class PlanoConverter : IParser<PlanoVO, Plano>, IParser<Plano, PlanoVO>
    {
        public Plano Parse(PlanoVO origem)
        {
            if (origem == null)
                return new Plano();
            else
            {
                var plano = new Plano()
                {
                    Id = origem.Id,
                    CodigoPlano = origem.CodigoPlano,
                    FranquiaInternet = origem.FranquiaInternet,
                    Minutos = origem.Minutos,
                    OperadoraId = origem.Operadora.Id,
                    Tipo = origem.Tipo,
                    Valor = origem.Valor
                };

                var listaDDDs = origem.DDDs;
                var planosDDDs = new List<PlanoDDD>();

                foreach (var item in listaDDDs)
                {
                    var planoDDD = new PlanoDDD()
                    {
                        DDDId = item.Id,
                        PlanoId = origem.Id
                    };
                    
                    planosDDDs.Add(planoDDD);
                }

                plano.PlanoDDDs = planosDDDs;
                return plano;
            }
        }

        public PlanoVO Parse(Plano origem)
        {
            if (origem == null)
                return new PlanoVO();
            else
            {
                var listaPlanoDDDs = origem.PlanoDDDs;
                var listaDDDs = new List<DDD>();

                foreach (var item in listaPlanoDDDs)
                {
                    listaDDDs.Add(item.DDD);
                }
                
                return new PlanoVO()
                {
                    Id = origem.Id,
                    CodigoPlano = origem.CodigoPlano,
                    FranquiaInternet = origem.FranquiaInternet,
                    Minutos = origem.Minutos,
                    Operadora = origem.Operadora,
                    DDDs = listaDDDs,
                    Tipo = origem.Tipo,
                    Valor = origem.Valor
                };
            }
        }

        public List<Plano> ParseList(List<PlanoVO> origem)
        {
            if (origem == null)
                return new List<Plano>();
            else
                return origem.Select(item => Parse(item)).ToList();
        }

        public List<PlanoVO> ParseList(List<Plano> origem)
        {
            if (origem == null)
                return new List<PlanoVO>();
            else
                return origem.Select(item => Parse(item)).ToList();
        }
    }
}
