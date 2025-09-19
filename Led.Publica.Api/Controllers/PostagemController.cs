using Led.Publica.Applications.DTO;
using Led.Publica.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Led.Publica.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostagemController : ControllerBase
    {
        private readonly PostagemServices _postagemServices;

        public PostagemController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var databaseService = new DatabaseService(connectionString!);
            _postagemServices = new PostagemServices(databaseService);

        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PostagemDTO postagem)
        {
            await _postagemServices.SalvarTema(postagem);
            return Ok(postagem);
        }
    }
}
