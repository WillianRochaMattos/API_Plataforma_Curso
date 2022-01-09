using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursosOnDemandAPI.Models
{
    public class Pagamentos
    {
        public long Id { get; set; }
        public long IdEstudante { get; set; }
        public double ValorPago { get; set; }
        public DateTime DataPagamento { get; set; }
    }
}
