using Newtonsoft.Json;
using System.Collections.Generic;
using Telefonia.Model.Base;

namespace Telefonia.Model
{
    public class Operadora: BaseEntity
    {
        public string Nome { get; set; }
        [JsonIgnore]
        public virtual ICollection<Plano> Planos { get; set; }
    }
}
