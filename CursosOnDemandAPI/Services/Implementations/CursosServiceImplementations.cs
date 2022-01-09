using CursosOnDemandAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading;

namespace CursosOnDemandAPI.Services.Implementations
{
    public class CursosServiceImplementations : ICursosServices
    {
        private volatile int count;
        private readonly IPagamentosServices _pagamentos;
        private readonly IMatriculaServices _matriculas;

        public CursosServiceImplementations(IPagamentosServices pagamentos, IMatriculaServices matriculas)
        {
            _pagamentos = pagamentos;
            _matriculas = matriculas;
        }

        public Cursos Create(Cursos cursos)
        {
            return cursos;
        }

        public void Delete(long id)
        {
            
        }

        public List<Cursos> FindAll()
        {
            List<Cursos> cursos = new List<Cursos>();
            for (int i = 0; i < 8; i++)
            {
                Cursos estudante = MockCursos(i);
                cursos.Add(estudante);
            }
            return cursos;
        }

        public Cursos FindBy(long id)
        {
            return new Cursos(IncrementAndGet(), "Curso Pyton", 126.90);
        }

        public Cursos Update(Cursos cursos)
        {
            return cursos;
        }

        private Cursos MockCursos(int i)
        {
            return new Cursos(IncrementAndGet(), "Curso Pyton" + i, 126.90);
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Matricula Matricular(Matricula matriculas)
        {
            try
            {
                Pagamentos pagamentos = null;
                pagamentos = _pagamentos.GetPagamentoByIdEstudante(matriculas.IdEstudante);
                if (pagamentos == null)
                    throw new Exception();

                Matricula matricula = _matriculas.Create(matriculas);
                return matricula;
            }
            catch (Exception)
            {
                throw new Exception("Não há pagamentos para este estudante");
            }
        }
    }
}
