using System.ComponentModel.DataAnnotations;

namespace AlunosAPI.Models{
    public class Aluno
    {
        public int Id{get; set;}
        [Required]
        [StringLength(80)]
        public string Name{get; set;}
        [Required]
        [StringLength(150)]
        [EmailAddress]
        public string Email{get; set;}
        [Required]
        public int Idade{get; set;}
    }
}