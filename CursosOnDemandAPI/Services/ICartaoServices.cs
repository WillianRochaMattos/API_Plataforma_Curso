using CursosOnDemandAPI.Models;
using System.Collections.Generic;

namespace CursosOnDemandAPI.Services
{
     public interface ICartaoServices
    {
        Cartao Create(Cartao cartao);
        Cartao FindBy(long id);
        List<Cartao> FindAll();
        Cartao Update(Cartao cartao);
        void Delete(long id);
    }
}
