namespace CursosOnDemandAPI.Models
{
    public class Cartao
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public long Numero { get; set; }
        public string DataValidade { get; set; }
        public int CodSeguranca { get; set; }
    }
}
