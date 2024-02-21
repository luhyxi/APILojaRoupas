using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LojaRoupas.Models.Interfaces;
using LojaRoupas.Models.Users;

namespace LojaRoupas.Models.Trade
{
    [Table("Devolucoes")]

    public class Devolucao : TradeBase, ITrade
    {
        public Devolucao()
        {

        }
        public Devolucao(Vendedor vendedor, Cliente cliente, List<Roupa> roupasOriginais)
        {
            DevolucaoId = IdCounter++;
            Vendedor = vendedor;
            VendedorId = Vendedor.UserId;
            Cliente = cliente;
            ClienteId = Cliente.UserId;
            RoupasOriginais = roupasOriginais;
            MomentoTransacao = DateTime.Now;
        }
        [Key]
        public int DevolucaoId { get; private set; }
        private DateTime? MomentoTransacao { get; set; }

        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }

        public int VendedorId { get; set; }
        public int ClienteId { get; set; }

        public List<Roupa> RoupasOriginais { get; set; }
    }
}
