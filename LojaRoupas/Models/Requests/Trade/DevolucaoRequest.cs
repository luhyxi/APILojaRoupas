using LojaRoupas.Models.Users;

namespace LojaRoupas.Models.Requests.Trade;

public class DevolucaoRequest
{
    public Vendedor Vendedor { get; set; }
    public Cliente Cliente { get; set; }
    public List<Roupa> RoupasOriginais { get; set; }
}
