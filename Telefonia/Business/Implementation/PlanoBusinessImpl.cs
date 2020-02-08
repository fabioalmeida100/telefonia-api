using System.Collections.Generic;
using System.Linq;
using Telefonia.Data.Convertes;
using Telefonia.Data.VO;
using Telefonia.Model.Enuns;
using Telefonia.Repository.Implementation;

namespace Telefonia.Business.Implementation
{
    public class PlanoBusinessImpl : IPlanoBusiness
    {
        private PlanoRepositoryImpl _repository;
        private readonly PlanoConverter _converter;

        public PlanoBusinessImpl(PlanoRepositoryImpl repository)
        {
            _repository = repository;
            _converter = new PlanoConverter();
        }


        public PlanoVO Create(PlanoVO plano)
        {
            var planoEntity = _converter.Parse(plano);
            planoEntity = _repository.Create(planoEntity);

            return _converter.Parse(planoEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<PlanoVO> FindAll()
        {
           return _converter.ParseList(_repository.FindAll());
        }

        public PlanoVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public PlanoVO Update(PlanoVO plano)
        {
            var planoEntity = _converter.Parse(plano);
            planoEntity = _repository.Update(planoEntity);
            return _converter.Parse(planoEntity);
        }

        public PlanoVO UpdateByCodigoPlano(PlanoVO plano)
        {
            var planoEntity = _converter.Parse(plano);
            planoEntity = _repository.UpdateByCodigoPlano(planoEntity);
            return _converter.Parse(planoEntity);
        }


        public PlanoVO FindByCodigoPlano(int codigoPlano, int ddd)
        {
            var plano = _repository.FindByCodigoPlano(codigoPlano);
            if (plano != null && plano.PlanoDDDs.FirstOrDefault(d => d.DDD.CodigoDDD == ddd) != null)
                return _converter.Parse(plano);
            else
                return new PlanoVO();
        }

        public List<PlanoVO> FindByTipo(TipoPlano tipoPlano, int ddd)
        {
            var plano = _repository.FindByTipo(tipoPlano, ddd);
            if (plano.Count > 0)
                return _converter.ParseList(plano);
            else
                return new List<PlanoVO>();
        }

        public List<PlanoVO> FindByOperadora(string operadora, int ddd)
        {
            var plano = _repository.FindByOperadora(operadora, ddd);
            if (plano.Count > 0)
                return _converter.ParseList(plano);
            else
                return new List<PlanoVO>();
        }

        public void DeleteByCodigoPlano(int codigoPlano)
        {
            _repository.DeleteByCodigoPlano(codigoPlano);
        }
    }
}
