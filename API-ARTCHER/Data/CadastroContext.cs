using API_ARTCHER.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.WebEncoders.Testing;

namespace API_ARTCHER.Data
{
    public class CadastroContext :DbContext
    {

        public CadastroContext (DbContextOptions <CadastroContext> options)
            :base (options)
        {

        }


        public DbSet<CadastroUsuario> CadastroDeUsuarios { get; set; }
        public DbSet<CadastroFilial> CadastroFilials { get; set; }
    }
}
