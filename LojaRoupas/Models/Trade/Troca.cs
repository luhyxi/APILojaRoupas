using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using LojaRoupas.Models.Interfaces;
using LojaRoupas.Models.Users;

namespace LojaRoupas.Models.Trade
{
    [Table("Trocas")]
    public class Troca : TradeBase, ITrade
    {
        public Troca()
        {
            
        }
        public Troca(Vendedor vendedor, Cliente cliente, List<Roupa> roupasOriginais, List<Roupa> roupasTrocadas)
        {
            TrocaId = IdCounter++;
            Vendedor = vendedor;
            VendedorId = Vendedor.UserId;
            Cliente = cliente;
            ClienteId = Cliente.UserId;
            RoupasOriginais = roupasOriginais;
            RoupasTrocadas = roupasTrocadas;
            MomentoTransacao = DateTime.Now;
        }
        [Key]
        public int TrocaId { get; private set; }
        private DateTime? MomentoTransacao { get; set; }

        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }

        public int VendedorId { get; set; }
        public int ClienteId { get; set; }

        public List<Roupa> RoupasOriginais { get; set; }
        public List<Roupa> RoupasTrocadas { get; set; }

    }
}
