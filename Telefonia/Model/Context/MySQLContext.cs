using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Telefonia.Model.Context
{
    public class MySQLContext: DbContext
    {
        public DbSet<Telefonia> Telefonias { get; set; }

        public MySQLContext()
        {

        }

        public MySQLContext(DbContextOptions<MySQLContext> options): base(options)
        {

        }
    }
}
