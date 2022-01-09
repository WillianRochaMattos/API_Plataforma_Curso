using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursosOnDemandAPI.Models
{
    public class Matricula
    {
        public long Id { get; set; }
        public long IdEstudante { get; set; }
        public List<long> ListaCursosMatriculados { get; set; }
    }
}
