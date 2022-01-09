using CursosOnDemandAPI.Models;
using System.Collections.Generic;

namespace CursosOnDemandAPI.Services
{
    public interface ICursosServices
    {
        Cursos Create(Cursos cursos);
        Cursos FindBy(long id);
        List<Cursos> FindAll();
        Cursos Update(Cursos cursos);
        void Delete(long id);
        Matricula Matricular(Matricula matriculas);
    }
}
