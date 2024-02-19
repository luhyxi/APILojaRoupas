using LojaRoupas.Models.Interfaces;
using LojaRoupas.Models.Trade;

namespace LojaRoupas.Models
{
    public class Cliente : IUser
    {
        private static int IdCounter = 0;

        public Cliente(string userName)
        {
            UserId = IdCounter++;
            UserName = userName;
        }
        public int UserId { get; private set; }
        public string UserName { get; set; }
        public ICollection<VendaRoupa>? Transacoes = null;
    }
}