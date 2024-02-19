using LojaRoupas.Models.Interfaces;

namespace LojaRoupas.Models.Trade
{
    public class VendaRoupa : ITrade
    {
        private static int IdCounter = 0;

        public VendaRoupa()
        {
        }
        public VendaRoupa(Vendedor vendedor, Cliente cliente, List<RoupaPeca> roupaPecas)
        {
            TransacaoId = IdCounter++;
            Vendedor = vendedor;
            VendedorId = Vendedor.UserId;
            Cliente = cliente;
            ClienteId = Cliente.UserId;
            RoupaPecas = roupaPecas;
            MomentoTransacao = DateTime.Now;
            Valor = RetornarValor();
        }

        public int TransacaoId { get; private set; }
        protected DateTime MomentoTransacao { get; set; }

        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }

        public int VendedorId { get; set; }
        public int ClienteId { get; set; }

        public List<RoupaPeca> RoupaPecas { get; set; }

        private decimal Valor { get; set; }

        private decimal RetornarValor() => RoupaPecas.Sum(x => x.Preco);

    }
}
