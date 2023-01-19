using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "O campo título é obrigatório")]
    [MaxLength(50, ErrorMessage = "O título não pode exceder 50 caracteres")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O campo gênero é obrigatório")]
    [StringLength(50, ErrorMessage = "O gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "O campo duração é obrigatório")]
    [Range(70, 190, ErrorMessage = "A duração deve ter entre 70 e 190 minutos")]
    public int Duracao { get; set; }
}
