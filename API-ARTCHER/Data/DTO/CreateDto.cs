using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_ARTCHER.Data.DTO
{
    public class CreateDto 
    {
        
       
        [Required(ErrorMessage = "Nome é obrigatorio!")]
        public string Nome { get; set; }

    

        [Required(ErrorMessage = "Email é obrigatorio!")]
        public string Email { get; set; }



        [Required(ErrorMessage = "usuario é obrigatorio!")]
        public string usuario { get; set; }


        [Required(ErrorMessage = "Senha é obrigatorio!")]
        public string Senha { get; set; }



    }
}
