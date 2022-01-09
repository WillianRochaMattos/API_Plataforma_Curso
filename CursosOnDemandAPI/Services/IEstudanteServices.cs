using CursosOnDemandAPI.Models;
using System.Collections.Generic;

namespace CursosOnDemandAPI.Services
{
    public interface IEstudanteServices
    {
        Estudante Create(Estudante estudante);
        Estudante FindBy(long id);
        List<Estudante> FindAll();
        Estudante Update(Estudante estudante);
        void Delete(long id);
    }
}
