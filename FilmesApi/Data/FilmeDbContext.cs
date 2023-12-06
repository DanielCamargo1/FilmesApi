using FilmesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Data; 

public class FilmeDbContext : DbContext
{
	public FilmeDbContext(DbContextOptions<FilmeDbContext> opts) : base(opts)
	{

	}

	public DbSet<Filme> Filmes { get; set; }
}
