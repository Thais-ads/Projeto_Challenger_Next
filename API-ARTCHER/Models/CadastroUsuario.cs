using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.Xml;

namespace API_ARTCHER.Models
{

    [Table("Usuario")]
    public class CadastroUsuario
    {
        [Key]
        [Column]
        [Display(Name = "Codigo")]
        public int Id { get; set; }

        [MaxLength(30)]
        [Column]
        [Display(Name = "Nome")]
        public string Nome { get; set; }


        [MaxLength(30)]
        [Column]
        [Display(Name = "Email")]
        public string Email { get; set; }



        [MaxLength(30)]
        [Column]
        [Display(Name = "Usuario")]
        public string Usuario { get; set; }


        [MaxLength(30)]
        [Column]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

     



    }
}
