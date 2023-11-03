using livrariaApi.context;
using livrariaApi.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace livrariaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class LivroController : ControllerBase
{
    private readonly LivroDbContext _context;

    public LivroController(LivroDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public IEnumerable<Livro> GetClientes()
    {
        return  _context.livros.ToList();
    }
    [HttpPost]
    [Route("InserirLivros")]
    public async Task<IActionResult> CreateLivros([FromBody] Livro livro)
    {
        try
        {
            _context.livros.Add(livro);
            var response = await _context.SaveChangesAsync();
            return Ok("Inserido Com Sucesso !!!");

        }
        catch (Exception ex)
        {
            throw new Exception(ex.ToString());
        }
    }
}
