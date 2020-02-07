using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telefonia.Model;
using Telefonia.Model.Context;
using Telefonia.Model.Enuns;
using Telefonia.Repository.Generic;

namespace Telefonia.Repository.Implementation
{
    public class PlanoRepositoryImpl : GenericRepository<Plano>
    {
        private IRepository<DDD> _repositoryDDD;
        private MySQLContext _context;

        public PlanoRepositoryImpl(MySQLContext context) : base(context)
        {
            _context = context;
        }

        public Plano FindByCodigoPlano(int codigoPlano)
        {
            return dataset.FirstOrDefault(p => p.CodigoPlano == codigoPlano);
        }

        public Plano FindByTipo(TipoPlano tipoPlano)
        {
            return dataset.FirstOrDefault(p => p.Tipo == tipoPlano);
        }

        public Plano FindByOperadora(string operadora)
        {
            return dataset.FirstOrDefault(p => p.Operadora == operadora);
        }
    }
}
