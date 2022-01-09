using CursosOnDemandAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CursosOnDemandAPI.Services.Implementations
{
    public class MatriculaServiceImplementations : IMatriculaServices
    {
        private int count;

        public Matricula Create(Matricula matriculas)
        {
            matriculas.Id = IncrementAndGet();
            return matriculas;
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public string EnviarEmail()
        {
            return "Parabéns! A sua matrícula foi criada com sucesso!";
        }

    }
}
