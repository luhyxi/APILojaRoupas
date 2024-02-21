using LojaRoupas.Models.Users;

namespace LojaRoupas.Models.Interfaces
{
    public interface ITrade
    {
        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }

        public int VendedorId { get; set; }
        public int ClienteId { get; set; }
    }
}
