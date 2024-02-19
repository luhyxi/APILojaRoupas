namespace LojaRoupas.Models.Trade
{
    public class TransacaoRoupa
    {
        private static int IdCounter = 0;

        public TransacaoRoupa()
        {
        }
        public TransacaoRoupa(Vendedor vendedor, Cliente cliente, List<RoupaPeca> roupaPecas)
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

        public int TransacaoId { get; set; }
        private DateTime? MomentoTransacao { get; set; }

        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }

        public int VendedorId { get; set; }
        public int ClienteId { get; set; }

        public List<RoupaPeca> RoupaPecas { get; set; }

        private decimal Valor { get; set; }

        private decimal RetornarValor() => RoupaPecas.Sum(x => x.Preco);

    }
}
