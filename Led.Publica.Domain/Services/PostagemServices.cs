using Led.Publica.Applications.DTO;
using System.Threading.Tasks;

namespace Led.Publica.Domain.Services;

public class PostagemServices
{
    private readonly DatabaseService _databaseService;

    public PostagemServices(DatabaseService databaseService)
    {
        _databaseService = databaseService;
    }

    public async Task SalvarTema(PostagemDTO postagem)
    {
        await _databaseService.SalvarTema(postagem.Tema);
       
    }
}
