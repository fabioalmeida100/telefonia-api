using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telefonia.Model;
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
    }
}
