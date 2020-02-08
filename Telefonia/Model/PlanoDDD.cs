using Newtonsoft.Json;

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
