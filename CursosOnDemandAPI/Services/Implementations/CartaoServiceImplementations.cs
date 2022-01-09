using CursosOnDemandAPI.Models;
using System.Collections.Generic;
using System.Threading;

namespace CursosOnDemandAPI.Services.Implementations
{
    public class CartaoServiceImplementations : ICartaoServices
    {
        private volatile int count;

        public Cartao Create(Cartao cartao)
        {
            return cartao;
        }

        public void Delete(long id)
        {
          
        }

        public List<Cartao> FindAll()
        {
            List<Cartao> cartoes = new List<Cartao>();
            for (int i = 0; i < 8; i++)
            {
                Cartao cartao = MockCartao(i);
                cartoes.Add(cartao);
            }
            return cartoes;
        }

        public Cartao FindBy(long id) => new()
        {
            Id = IncrementAndGet(),
            Nome = "JOAO R JUNIOR",
            Numero = 12345864855,
            DataValidade = "12/28",
            CodSeguranca = 125
        };

        public Cartao Update(Cartao cartao)
        {
            return cartao;
        }

        private Cartao MockCartao(int i)
        {
            return new Cartao
            {
                Id = IncrementAndGet(),
                Nome = "JOAO R JUNIOR",
                Numero = 1234,
                DataValidade = "12/28",
                CodSeguranca = 125
            };
        }
        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
