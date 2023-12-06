using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O filme precisa conter um nome")]
    public string Nome { get; set; }
    [Required(ErrorMessage = "o filme precisa conter um genero")]
    [MaxLength(50, ErrorMessage = " O texto não pode exceder 50 caracteres")]
    public string Genero { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage ="O filme deve ter de 70 a 600 minutos")]
    public int Duracao { get; set; }
}
