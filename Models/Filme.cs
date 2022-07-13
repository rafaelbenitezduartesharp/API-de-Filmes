using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Filme
    { 
       [Key]
       [Required]
        public int Id { get; internal set; }
        [Required(ErrorMessage = "O campo titulo é obrigatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor é obrigatorio")]
        public string Diretor { get; set; }
        [StringLength(30,ErrorMessage = "O gênero não pode passar de 30 caracteres")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "A duração deve ter no minimo 1 e no máximo 600 minutos")]
        public int Duracao { get; set; }
    }
}
