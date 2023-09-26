
using System.ComponentModel.DataAnnotations;

namespace API_ARTCHER.Data.DTO
{
    public class UpdateUsuario
    {

        
            [Required(ErrorMessage = "Nome é obrigatorio!")]
            public string Nome { get; set; }


            [Required(ErrorMessage = "Senha é obrigatorio!")]
            public string Senha { get; set; }

            [Required(ErrorMessage = "Email é obrigatorio!")]
            public string Email { get; set; }

            public DateTime Data = DateTime.Now;


    }
}
