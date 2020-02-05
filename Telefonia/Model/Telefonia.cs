using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telefonia.Model.Base;
using Telefonia.Model.Enuns;

namespace Telefonia.Model
{
    public class Telefonia: BaseEntity
    {
        public int CodigoPlano { get; set; }
        public int Minutos { get; set; }
        public int FranquiaInternet { get; set; }
        public double Valor { get; set; }
        public TipoPlano Tipo { get; set; }
        public string Operadora { get; set; }
    }
}
