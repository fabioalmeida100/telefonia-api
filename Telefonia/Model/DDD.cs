using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telefonia.Model.Base;

namespace Telefonia.Model
{
    public class DDD: BaseEntity
    {
        public int CodigoDDD { get; set; }
        [JsonIgnore]
        public virtual ICollection<PlanoDDD> PlanoDDDs { get; set; } = new List<PlanoDDD>();
    }
}
