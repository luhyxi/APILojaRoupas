using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LojaRoupas.Models.Enums;

namespace LojaRoupas.Models.Users
{
    [Table("Roupas")]
    public class Roupa
    {
        private static int IdCounter = 0;

        public Roupa(string? nomePeca, decimal preco, TipoRoupa tipo)
        {
            RoupaId = IdCounter++;
            NomePeca = nomePeca;
            Preco = preco;
            Tipo = tipo;
        }
        
        [Key]
        public int RoupaId { get; private set; }
        public string? NomePeca { get; set; }
        public decimal Preco { get; set; }
        public TipoRoupa Tipo { get; set; }
    }
}
