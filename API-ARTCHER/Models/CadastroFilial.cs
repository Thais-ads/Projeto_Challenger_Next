using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.Xml;

namespace API_ARTCHER.Models
{

    [Table("Filiais")]
    public class CadastroFilial

    {

        [Key]
        [Column]
        [Display(Name = "Codigo")]
        public int Id { get; set; }

        [MaxLength(30)]
        [Column]
        [Display(Name = "NomeDaFilial")]
        public string NomeDaFilial { get; set; }


        [MaxLength(30)]
        [Column]
        [Display(Name = "Contato")]

        public string Contato { get; set; }

        [MaxLength(30)]
        [Column]
        [Display(Name = "Endereco")]

        public string Endereco { get; set; }



        [MaxLength(30)]
        [Column]
        [Display(Name = "Numero")]

        public int Numero { get; set; }


        [MaxLength(30)]
        [Column]
        [Display(Name = "Bairro")]

        public string Bairro { get; set; }



        [MaxLength(200)]
        [Column]
        [Display(Name = "Descriacao")]

        public string Descricao { get; set; }

        [MaxLength(30)]
        [Column]
        [Display(Name = "Foto")]

        public string Foto { get; set; }

        [Column]
        [Display(Name = "DataAlteracao")]
        public DateTime Data { get; set; }
    }
}
