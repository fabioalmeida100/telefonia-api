using System.Collections.Generic;
using Telefonia.Model;
using Telefonia.Model.Enuns;

namespace Telefonia.Data.VO
{
    public class PlanoVO
    {
        public long Id { get; set; }
        public int CodigoPlano { get; set; }
        public int Minutos { get; set; }
        public int FranquiaInternet { get; set; }
        public decimal Valor { get; set; }
        public TipoPlano Tipo { get; set; }
        public Operadora Operadora { get; set; }
        public ICollection<DDD> DDDs { get; set; }
    }
}
