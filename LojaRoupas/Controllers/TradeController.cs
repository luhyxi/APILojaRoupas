using LojaRoupas.Models.Interfaces;
using LojaRoupas.Models.Requests.Trade;
using LojaRoupas.Models.Trade;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LojaRoupas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeController : ControllerBase, ITradeLogic
    {
        // GET: api/<TradeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TradeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TradeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TradeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpPost]
        public ActionResult<Venda> RegisterVenda(VendaRequest venda)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult<Troca> RegisterTroca(VendaRequest troca)
        {
            throw new NotImplementedException();
        }
        
        [HttpPost]
        public ActionResult<Devolucao> RegisterDevolucao(DevolucaoRequest devolucao)
        {
            throw new NotImplementedException();
        }

        [HttpGet("Venda/{vendaId}")]

        public ActionResult<Venda> GetVenda(int vendaId)
        {
            throw new NotImplementedException();
        }
        
        [HttpGet("Troca/{trocaId}")]
        public ActionResult<Troca> GetTroca(int trocaId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("Devolucao/{devolucaoId}")]
        public ActionResult<Devolucao> GetDevolucao(int devolucaoId)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public ActionResult<List<Venda>> GetVendas([FromQuery]List<int> vendas)
        {
            throw new NotImplementedException();
        }
        
        [HttpGet]
        public ActionResult<List<Troca>> GetTrocas([FromQuery]List<int> trocas)
        {
            throw new NotImplementedException();
        }
        
        [HttpGet]
        public ActionResult<List<Devolucao>> GetDevolucoes([FromQuery]List<int> devolucaos)
        {
            throw new NotImplementedException();
        }
    }
}
