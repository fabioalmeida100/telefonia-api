using System;
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

        public Plano FindByCodigoPlano(int codigoPlano, int ddd)
        {
            return dataset
                .Where(
                    p => p.CodigoPlano == codigoPlano 
                    && p.PlanoDDDs.Where(d => d.DDD.CodigoDDD == ddd).Any())
                .FirstOrDefault();
                
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

        public Plano UpdateByCodigoPlano(Plano plano)
        {
            var planoEntity = dataset.Where(p => p.CodigoPlano == plano.CodigoPlano).FirstOrDefault();
            if (planoEntity != null)
            {
                plano.Id = planoEntity.Id;
                _context.Entry(planoEntity).CurrentValues.SetValues(plano);
 
                foreach (var item in plano.PlanoDDDs)
                {
                    if (planoEntity.PlanoDDDs.Where(p => p.PlanoId == item.PlanoId &&
                        p.DDDId == item.DDDId).FirstOrDefault() == null)
                    {
                        var planoDDD = new PlanoDDD()
                        {                   
                            DDDId = item.DDDId,
                            PlanoId = planoEntity.Id                   
                        };
                        planoEntity.PlanoDDDs.Add(planoDDD);                 
                    }
                }
                _context.SaveChanges();
                return plano;
            }
            else
                return new Plano();

        }

        public void DeleteByCodigoPlano(int codigoPlano)
        {
            var plano = dataset.Where(p => p.CodigoPlano == codigoPlano).FirstOrDefault();
            if (plano == null)
            {
                throw new Exception("Plano não existe");
            }
            else
            {
                _context.Remove(plano);
                _context.SaveChanges();
            }
        }

    }
}
