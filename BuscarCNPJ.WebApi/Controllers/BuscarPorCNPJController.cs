using BuscarCNPJ.Domain.Entities;
using BuscarCNPJ.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace BuscarCNPJ.WebApi.Controllers
{
    [Route("api/BuscarPorCNPJ")]
    [ApiController]
    public class BuscarPorCNPJController : ControllerBase
    {
        protected readonly ICnpjRepository _repository;
        private HttpClient _httpClient;
        public BuscarPorCNPJController(ICnpjRepository repository, HttpClient httpClient)
        {
            _repository = repository;
            _httpClient = httpClient;
        }
        [HttpGet("{cnpj}")]
        public async Task<IActionResult> BuscarPorCNPJ(string cnpj)
        {
            var item = await _repository.Get(cnpj);
            return Ok(item);
        }
    }
}
