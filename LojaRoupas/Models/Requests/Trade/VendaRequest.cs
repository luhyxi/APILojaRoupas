using LojaRoupas.Models.Users;

namespace LojaRoupas.Models.Requests.Trade;

public class VendaRequest
{
    public Vendedor Vendedor { get; set; }
    public Cliente Cliente { get; set; }
    public List<Roupa> RoupaPecas { get; set; }
}
