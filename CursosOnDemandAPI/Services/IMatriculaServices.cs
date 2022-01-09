using CursosOnDemandAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursosOnDemandAPI.Services
{
    public interface IMatriculaServices
    {
        Matricula Create(Matricula matriculas);
        string EnviarEmail();
    }
}
