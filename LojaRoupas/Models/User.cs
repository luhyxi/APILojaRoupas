using LojaRoupas.Models.Enums;
using LojaRoupas.Models.Trade;

namespace LojaRoupas.Models
{
    public interface IUser
    {
        public int UserId { get; }
        public string UserName { get; set; }

    }
}
