using LojaRoupas.Models.Interfaces;

namespace LojaRoupas.Models.Trade
{
    public class DevolucaoRoupa : ITrade
    {
        private static int IdCounter = 0;
        public DevolucaoRoupa()
        {

        }
        public DevolucaoRoupa(Vendedor vendedor, Cliente cliente, List<RoupaPeca> roupasOriginais)
        {
            TransacaoId = IdCounter++;
            Vendedor = vendedor;
            VendedorId = Vendedor.UserId;
            Cliente = cliente;
            ClienteId = Cliente.UserId;
            RoupasOriginais = roupasOriginais;
            MomentoTransacao = DateTime.Now;
        }
        public int TransacaoId { get; private set; }
        private DateTime? MomentoTransacao { get; set; }

        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }

        public int VendedorId { get; set; }
        public int ClienteId { get; set; }

        public List<RoupaPeca> RoupasOriginais { get; set; }
    }
}
