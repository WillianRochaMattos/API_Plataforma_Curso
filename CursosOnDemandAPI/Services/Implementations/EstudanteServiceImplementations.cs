using CursosOnDemandAPI.Models;
using System.Collections.Generic;
using System.Threading;

namespace CursosOnDemandAPI.Services.Implementations
{
    public class EstudanteServiceImplementations : IEstudanteServices
    {
        private int count; 

        public Estudante Create(Estudante estudante)
        {
            estudante.Id = IncrementAndGet();
            return estudante;
        }

        public void Delete(long id)
        {
            
        }

        public List<Estudante> FindAll()
        {
            List<Estudante> estudantes = new List<Estudante>();
            for (int i = 0; i < 8; i++) 
            {
                Estudante estudante = MockEstudante(i);
                estudantes.Add(estudante);
            }
            return estudantes;
        }

        public Estudante FindBy(long id) => new()
        {
            Id = IncrementAndGet(),
            Nome = "Name",
            Email = "name@hotmail.com",
            Senha = "1234"
        };

        public Estudante Update(Estudante estudante)
        {
            return estudante;
        }

        private Estudante MockEstudante(int i)
        {
            return new Estudante
            {
                Id = IncrementAndGet(),
                Nome = "Name" + i,
                Email = "name@hotmail.com" + i,
                Senha = "1234"
            };
        }
        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
