using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LojaRoupas.Models.Interfaces;
using LojaRoupas.Models.Trade;

namespace LojaRoupas.Models.Users
{
    [Table("Vendedores")]
    public class Vendedor : IUser
    {
        private static int IdCounter = 0;

        public Vendedor(string userName)
        {
            UserId = IdCounter++;
            UserName = userName;
            Vendas = null;
            Trocas = null;
            Devolucoes = null;
        }
        [Key]
        public int UserId { get; private set; }
        
        public string UserName { get; set; }
        public ICollection<Venda>? Vendas { get; private set; }
        public ICollection<Troca>? Trocas { get; private set; }
        public ICollection<Devolucao>?  Devolucoes { get; private set; }


    }
}
