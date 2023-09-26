using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_ARTCHER.Data.DTO
{
    public class FilialDto 
    {
        
       
        [Required(ErrorMessage = "Nome da filial é obrigatorio!")]
        public string NomeDaFilial { get; set; }

       
        [Required(ErrorMessage = "Contato é obrigatorio!")]
        public string Contato { get; set; }


        [Required(ErrorMessage = "Endereco é obrigatorio!")]
        public string Endereco { get; set; }


        [Required(ErrorMessage = "Numero é obrigatorio!")]
        public int Numero { get; set; }


        [Required(ErrorMessage = "Bairro é obrigatorio!")]
        public string Bairro { get; set; }


        [Required(ErrorMessage = "Descriacao é obrigatorio!")]
        public string Descriacao { get; set; }

        public string Foto { get; set; }

        public DateTime Data { get; set; } = DateTime.Now ;


    }
}
