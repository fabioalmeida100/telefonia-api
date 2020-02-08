using System.Collections.Generic;
using System.Linq;
using Telefonia.Model;
using Telefonia.Model.Context;
using Telefonia.Model.Enuns;
using Telefonia.Repository.Generic;

namespace Telefonia.Repository.Implementation
{
    public class PlanoRepositoryImpl : GenericRepository<Plano>
    {
        public PlanoRepositoryImpl(MySQLContext context) : base(context)
        {
           
        }

        public Plano FindByCodigoPlano(int codigoPlano)
        {
            return dataset.FirstOrDefault(p => p.CodigoPlano == codigoPlano);
        }

        public List<Plano> FindByTipo(TipoPlano tipoPlano, int ddd)
        {
            var planos = dataset
                .Where(p => p.Tipo == tipoPlano && p.PlanoDDDs.Where(d => d.DDD.CodigoDDD == ddd)
                .Any()).ToList();
            return planos;
        }

        public List<Plano> FindByOperadora(string operadora, int ddd)
        {
            var planos = dataset
                .Where(p => p.Operadora.Nome == operadora && p.PlanoDDDs.Where(d => d.DDD.CodigoDDD == ddd)
                .Any()).ToList();

            return planos;
      
        }
    }
}
