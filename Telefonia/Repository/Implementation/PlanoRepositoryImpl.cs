using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telefonia.Model;
using Telefonia.Model.Context;
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
    }
}
