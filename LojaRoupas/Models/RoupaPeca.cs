using LojaRoupas.Models.Enums;

namespace LojaRoupas.Models
{
    public class RoupaPeca
    {
        private static int IdCounter = 0;

        public RoupaPeca(string? nomePeca, decimal preco, TipoRoupa tipo)
        {
            RoupaId = IdCounter++;
            NomePeca = nomePeca;
            Preco = preco;
            Tipo = tipo;
        }

        public int RoupaId { get; private set; }
        public string? NomePeca { get; set; }
        public decimal Preco { get; set; }
        public TipoRoupa Tipo { get; set; }
    }
}
