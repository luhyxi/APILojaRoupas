using LojaRoupas.Models.Users;

namespace LojaRoupas.Models.Requests.Trade;

public class TrocaRequest
{
    public Vendedor Vendedor { get; set; }
    public Cliente Cliente { get; set; }
    public List<Roupa> RoupasOriginais { get; set; }
    public List<Roupa> RoupasTrocadas { get; set; }
}
