using livrariaApi.models;
using Microsoft.AspNetCore.Mvc;

namespace livrariaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class LivroController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<LivroController> _logger;

    public LivroController(ILogger<LivroController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetLivros")]
    public IEnumerable<Livro> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Livro
        {
            AnoPublicado = "teste",
            
        })
        .ToArray();
    }
}
