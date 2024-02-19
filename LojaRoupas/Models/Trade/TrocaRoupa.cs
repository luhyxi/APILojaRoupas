using System.Drawing;

namespace LojaRoupas.Models.Trade
{
    public class TrocaRoupa
    {
        private static int IdCounter = 0;
        public TrocaRoupa()
        {
            
        }
        public TrocaRoupa(Vendedor vendedor, Cliente cliente, List<RoupaPeca> roupasOriginais, List<RoupaPeca> roupasTrocadas)
        {
            TransacaoId = IdCounter++;
            Vendedor = vendedor;
            VendedorId = Vendedor.UserId;
            Cliente = cliente;
            ClienteId = Cliente.UserId;
            RoupasOriginais = roupasOriginais;
            RoupasTrocadas = roupasTrocadas;
            MomentoTransacao = DateTime.Now;
        }
        public int TransacaoId { get; private set; }
        private DateTime? MomentoTransacao { get; set; }

        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }

        public int VendedorId { get; set; }
        public int ClienteId { get; set; }

        public List<RoupaPeca> RoupasOriginais { get; set; }
        public List<RoupaPeca> RoupasTrocadas { get; set; }

    }
}
