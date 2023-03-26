using System.ComponentModel.DataAnnotations;

namespace Controle_de_cadastros.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do contato")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "Digite o E-mail")]
        [EmailAddress(ErrorMessage = "O e-mail informado nao e valido")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Digite o numero")]
        [Phone(ErrorMessage = "O celular informado nao e valido")]
        public string? Numero { get; set; }
    }
}
