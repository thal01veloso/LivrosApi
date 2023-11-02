using livrariaApi.context;
using livrariaApi.models;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI;

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
        return _context.livros.ToList();
    }
    [HttpPost]
    public async Task<IActionResult> CreateLivros([FromBody] Livro livro)
    {
        try
        {
        _context.livros.Add(livro);
        await _context.SaveChangesAsync();
        return Ok(livro);

        }catch (Exception ex)
        {
            throw new Exception(ex.ToString());
        }
    }
}
