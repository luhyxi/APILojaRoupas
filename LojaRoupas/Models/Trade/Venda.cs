using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LojaRoupas.Models.Interfaces;
using LojaRoupas.Models.Users;

namespace LojaRoupas.Models.Trade
{
    [Table("Vendas")]
    public class Venda : TradeBase, ITrade
    {
        public Venda()
        {
        }
        public Venda(Vendedor vendedor, Cliente cliente, List<Roupa> roupaPecas)
        {
            VendaId = IdCounter++;
            Vendedor = vendedor;
            VendedorId = Vendedor.UserId;
            Cliente = cliente;
            ClienteId = Cliente.UserId;
            RoupaPecas = roupaPecas;
            MomentoTransacao = DateTime.Now;
            Valor = RetornarValor();
        }
        [Key]

        public int VendaId { get; private set; }
        protected DateTime MomentoTransacao { get; set; }

        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }

        public int VendedorId { get; set; }
        public int ClienteId { get; set; }

        public List<Roupa> RoupaPecas { get; set; }

        private decimal Valor { get; set; }

        private decimal RetornarValor() => RoupaPecas.Sum(x => x.Preco);

    }
}
