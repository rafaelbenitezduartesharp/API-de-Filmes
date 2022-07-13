using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Dtos
{
    public class ReadFilmeDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Titulo é obrigatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor é obrigatorio")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O gênero não pode passar de 30 caracteres")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "A duração deve ter no minimo 1 e no máximo 600 minutos")]
        public int Duracao { get; set; }
        public DateTime HoraDaConsulta { get; internal set; }
    }
}
