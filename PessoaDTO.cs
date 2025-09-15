using exemploCrud.Validations;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class PessoaDTO
    {
        [Required(ErrorMessage =  "Nome Obrigatorio")]
        [MinLength(3, ErrorMessage = "Digite no minimo 3 letras")]
        [MaxLength(20, ErrorMessage = "Digite no maximo 20 letras")]
        public string nome { get; set; }
        [CpfValidation(ErrorMessage = "Digite um cpf valido")]
        public string cpf { get; set; }
        [Range(0, 150, ErrorMessage = "Idade invalida")]
        public int peso { get; set; }
        [Range(0, 3, ErrorMessage = "Altura invalida")]
        public int altura { get; set; }
    }
}
