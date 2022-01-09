namespace CursosOnDemandAPI.Models
{
    public class Cursos
    {
        public long Id { get; set; }
        public string NomeCurso { get; set; }
        public double ValorCurso { get; set; }

        public Cursos(long id, string nomeCurso, double valorCurso)
        {
            Id = id;
            NomeCurso = nomeCurso;
            ValorCurso = valorCurso;
        }
    }
}
