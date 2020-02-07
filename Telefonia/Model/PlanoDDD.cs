using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telefonia.Model.Base;

namespace Telefonia.Model
{
    public class PlanoDDD
    {      
        public long PlanoId { get; set; }
        [JsonIgnore]
        public virtual Plano Plano { get; set; }

        public long DDDId { get; set; }
        [JsonIgnore]
        public virtual DDD DDD { get; set; }

    }

}
