using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new();
    private static int id = 0;

    [HttpPost]
    public IActionResult AdicinarFilme([FromBody] Filme filme)
    {
        filme.Id = id++;
        filmes.Add(filme);
        return CreatedAtAction(nameof(RecuperaFilmePorId), new { id = filme.Id }, filme);
    }

    [HttpGet]
    public IEnumerable<Filme> RestaurarFilmes([FromQuery] int skip, [FromQuery] int take)
    {
        return filmes.Skip(skip).Take(take);  
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaFilmePorId(int id)
    {

        var filmeN = filmes.FirstOrDefault(filme => filme.Id == id);
        if(filmeN == null) return NotFound();
        return Ok(filmeN);
    }
}
