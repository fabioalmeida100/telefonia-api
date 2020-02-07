using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public string Operadora { get; set; }
        public virtual ICollection<PlanoDDD> PlanoDDDs { get; set; } = new List<PlanoDDD>();
    }
}
