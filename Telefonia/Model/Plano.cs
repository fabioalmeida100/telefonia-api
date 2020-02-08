using Newtonsoft.Json;
using System.Collections.Generic;
using Telefonia.Model.Base;
using Telefonia.Model.Enuns;

namespace Telefonia.Model
{
    public class Plano: BaseEntity
    {
        public int CodigoPlano { get; set; }
        public int Minutos { get; set; }
        public int FranquiaInternet { get; set; }
        public decimal Valor { get; set; }
        public TipoPlano Tipo { get; set; }

        public long OperadoraId { get;set; }
        [JsonIgnore]
        public virtual Operadora Operadora { get; set; }
        [JsonIgnore]
        public virtual ICollection<PlanoDDD> PlanoDDDs { get; set; } = new List<PlanoDDD>();
    }
}
