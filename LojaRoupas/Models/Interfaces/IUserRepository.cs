using LojaRoupas.Models.Requests;
using LojaRoupas.Models.Requests.Trade;
using LojaRoupas.Models.Requests.Users;
using LojaRoupas.Models.Trade;
using LojaRoupas.Models.Users;

namespace LojaRoupas.Models.Interfaces;

public interface IUserRepository
{
    public List<Cliente> GetClientes(List<int> id);
    public List<Vendedor> GetVendedores(List<int> id);
    public List<Roupa> GetRoupas(List<int> id);
    
    public Cliente AddCliente(RequestCliente cliente);
    public Vendedor AddVendedor(RequestVendedor vendedor);
    public Roupa AddRoupa(RequestRoupa roupa);
    
    public Cliente DeleteCliente(RequestCliente cliente);
    public Vendedor DeleteVendedor(RequestVendedor vendedor);
    public Roupa DeleteRoupa(RequestRoupa roupa);
    
    public Venda RegisterVenda(VendaRequest venda);
    public Troca RegisterTroca(VendaRequest troca);
    public Devolucao RegisterDevolucao(DevolucaoRequest devolucao);
    
    public Venda GetVenda(VendaRequest venda);
    public Troca GetTroca(VendaRequest troca);
    public Devolucao GetDevolucao(DevolucaoRequest devolucao);
    
    public List<Venda> GetVendas(List<VendaRequest> vendas);
    public List<Troca> GetTrocas(List<VendaRequest> trocas);
    public List<Devolucao> GetDevolucoes(List<DevolucaoRequest> devolucaos);
}