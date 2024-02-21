using LojaRoupas.Models.Requests;
using LojaRoupas.Models.Requests.Trade;
using LojaRoupas.Models.Requests.Users;
using LojaRoupas.Models.Trade;
using LojaRoupas.Models.Users;
using Microsoft.AspNetCore.Mvc;

namespace LojaRoupas.Models.Interfaces;

public interface ITradeLogic
{
    public ActionResult<Venda> RegisterVenda(VendaRequest venda);
    public ActionResult<Troca> RegisterTroca(VendaRequest troca);
    public ActionResult<Devolucao> RegisterDevolucao(DevolucaoRequest devolucao);
    
    public ActionResult<Venda> GetVenda(int vendaId);
    public ActionResult<Troca> GetTroca(int trocaId);
    public ActionResult<Devolucao> GetDevolucao(int devolucaoId);
    
    public ActionResult<List<Venda>> GetVendas(List<int> vendas);
    
    public ActionResult<List<Troca>> GetTrocas(List<int> trocas);
    
    public ActionResult<List<Devolucao>> GetDevolucoes(List<int> devolucaos);
}