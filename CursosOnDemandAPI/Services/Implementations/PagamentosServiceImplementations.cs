using CursosOnDemandAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CursosOnDemandAPI.Services.Implementations
{
    public class PagamentosServiceImplementations : IPagamentosServices
    {
        private volatile int count;

        private List<Pagamentos> MockPagamentos()
        {
            List<Pagamentos> listaPagamentos = new List<Pagamentos>();
            Pagamentos pagamento = new Pagamentos();

            pagamento.Id = IncrementAndGet();
            pagamento.DataPagamento = DateTime.Parse("15/01/2021 12:00:00");
            pagamento.IdEstudante = 1;
            pagamento.ValorPago = 200.0;
            listaPagamentos.Add(pagamento);

            pagamento = new Pagamentos(); 

            pagamento.Id = IncrementAndGet();
            pagamento.DataPagamento = DateTime.Parse("18/01/2021 12:00:00");
            pagamento.IdEstudante = 2;
            pagamento.ValorPago = 200.0;
            listaPagamentos.Add(pagamento);

            pagamento = new Pagamentos();

            pagamento.Id = IncrementAndGet();
            pagamento.DataPagamento = DateTime.Parse("01/01/2021 12:00:00");
            pagamento.IdEstudante =4;
            pagamento.ValorPago = 200.0;
            listaPagamentos.Add(pagamento);

            pagamento = new Pagamentos();

            pagamento.Id = IncrementAndGet();
            pagamento.DataPagamento = DateTime.Parse("01/03/2021 15:00:00");
            pagamento.IdEstudante = 5;
            pagamento.ValorPago = 200.0;
            listaPagamentos.Add(pagamento);

            pagamento = new Pagamentos();

            pagamento.Id = IncrementAndGet();
            pagamento.DataPagamento = DateTime.Parse("03/04/2021 13:00:00");
            pagamento.IdEstudante = 6;
            pagamento.ValorPago = 200.0;
            listaPagamentos.Add(pagamento);

            pagamento = new Pagamentos();

            pagamento.Id = IncrementAndGet();
            pagamento.DataPagamento = DateTime.Parse("03/06/2021 13:00:00");
            pagamento.IdEstudante = 7;
            pagamento.ValorPago = 200.0;
            listaPagamentos.Add(pagamento);

            return listaPagamentos;

        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Pagamentos GetPagamentoByIdEstudante(long idEstudante)
        {
            List<Pagamentos> pagamentos = MockPagamentos();
            Pagamentos pagamento = pagamentos.Single(s => s.IdEstudante == idEstudante);
            return pagamento;
        }


    }
}
