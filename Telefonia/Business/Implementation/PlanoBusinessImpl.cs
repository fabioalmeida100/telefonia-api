using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telefonia.Model;
using Telefonia.Model.Enuns;
using Telefonia.Repository.Generic;
using Telefonia.Repository.Implementation;

namespace Telefonia.Business.Implementation
{
    public class PlanoBusinessImpl : IPlanoBusiness
    {
        private PlanoRepositoryImpl _repository;

        public PlanoBusinessImpl(PlanoRepositoryImpl repository)
        {
            _repository = repository;
        }


        public Plano Create(Plano plano)
        {
            return _repository.Create(plano);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Plano> FindAll()
        {
           return _repository.FindAll();
        }

        public Plano FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Plano Update(Plano plano)
        {
            return _repository.Update(plano);
        }

        public Plano FindByCodigoPlano(int codigoPlano, int ddd)
        {
            var plano = _repository.FindByCodigoPlano(codigoPlano);
            if (plano != null && plano.PlanoDDDs.FirstOrDefault(d => d.DDD.CodigoDDD == ddd) != null)
                return plano;
            else
                return new Plano();
        }

        public Plano FindByTipo(TipoPlano tipoPlano, int ddd)
        {
            var plano = _repository.FindByTipo(tipoPlano);
            if (plano != null && plano.PlanoDDDs.FirstOrDefault(d => d.DDD.CodigoDDD == ddd) != null)
                return plano;
            else
                return new Plano();
        }

        public Plano FindByOperadora(string operadora, int ddd)
        {
            var plano = _repository.FindByOperadora(operadora);
            if (plano != null && plano.PlanoDDDs.FirstOrDefault(d => d.DDD.CodigoDDD == ddd) != null)
                return plano;
            else
                return new Plano();
        }
    }
}
