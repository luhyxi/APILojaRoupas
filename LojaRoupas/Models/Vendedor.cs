using LojaRoupas.Models.Enums;
using LojaRoupas.Models.Interfaces;
using LojaRoupas.Models.Trade;
using System.Diagnostics.Metrics;

namespace LojaRoupas.Models
{
    public class Vendedor : IUser
    {

        public Vendedor(string userName)
        {
            UserId = IdCounter++;
            UserName = userName;
        }
        private static int IdCounter = 0;
        public int UserId { get; private set; }
        public string UserName { get; set; }
        public ICollection<VendaRoupa>? Transacoes = null;

    }
}
