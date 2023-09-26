using API_ARTCHER.Data;
using API_ARTCHER.Data.DTO;
using API_ARTCHER.Models;
//using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace API_ARTCHER.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class CadastroUsuarioController: ControllerBase
    {



        // injeção dependence
        private CadastroContext context;
        //private IMapper _mapper;


        public CadastroUsuarioController(CadastroContext teste/*, IMapper mapper*/)
        {
            context = teste;
            //_mapper = mapper;
        }

        /// <summary>
        /// Adiciona um usuario ao banco de dados
        /// </summary>
        /// <param name="id">Objeto com os campos necessários para criação de um filme</param>
        /// <returns>IActionResult</returns>
        /// <response code="200">Caso inserção seja feita com sucesso</response>


        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        //retornando de acordo com o VERBO HTTP, então adicionamos o IACTIONRESULT
        public IActionResult RecuperaUsuarioID(int id)
        {

            //usuario que eu estou buscando tem o ID igual ao o Parametro recebido;
            var usuario = context.CadastroDeUsuarios.FirstOrDefault(usuario => usuario.Id == id);
            if (usuario == null) return NotFound();
            return Ok(usuario);



            //Status 201,404
        }










        /// <summary>
        /// Valida o login do Usuario ao banco de dados
        /// </summary>
        /// <param name="dto">Object transfer</param>
        /// <returns>IActionResult</returns>
        /// <response code="200">Caso inserção seja feita com sucesso</response>
        [HttpPost("LoginUsuario")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        //retornando de acordo com o VERBO HTTP, então adicionamos o IACTIONRESULT
        public async Task<IActionResult> LoginUsuario([FromBody] LoginDto acesso)
        {

            //usuario que eu estou buscando tem o ID igual ao o Parametro recebido;

            var validaEmail = await context.CadastroDeUsuarios.FirstOrDefaultAsync(valemail => valemail.Email == acesso.EmailUser);
            var validaUsuario = await context.CadastroDeUsuarios.FirstOrDefaultAsync(valusuario => valusuario.Usuario == acesso.Senha);
            LoginDto loginUsuario = new LoginDto();

            if (validaEmail == null && validaUsuario == null)
            {
                return NotFound("Usuario não cadastrado");
            }
            else if (validaEmail == null && validaUsuario != null)
            {
                loginUsuario.EmailUser = validaUsuario.Usuario;
                loginUsuario.Senha = validaUsuario.Senha;
            }
            else
            {
                loginUsuario.EmailUser = validaEmail.Email;
                loginUsuario.Senha = validaEmail.Senha;
            }

            if (loginUsuario.Senha == acesso.Senha)
            {
                return Ok("Autenticado!!!");
            }

            return NotFound("Senha invalida!!!");
            throw new ApplicationException("Falha");


            //Status 201,404
        }














        /// <summary>
        /// Adiciona um usuario ao banco de dados
        /// </summary>
        /// <param name="createDto">Objeto com os campos necessários para criação de um filme</param>
        /// <returns>IActionResult</returns>
        /// <response code="201">Caso inserção seja feita com sucesso</response>

        [HttpPost("CadastrandoUsuario")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult CadastroCliente( [FromBody]  CreateDto dto)
        {

            
                CadastroUsuario usuario = new CadastroUsuario
                {
                    Nome = dto.Nome,
                    Senha = dto.Senha,
                    Email = dto.Email,
                    Usuario = dto.usuario
                    
                };


                context.Add(usuario);
                context.SaveChanges();

                return Ok(usuario);
                //Status 200,201
            
            
            //Testebanco testebanco = _mapper.Map<Testebanco>(dto);



        }



        /// <summary>
        /// Adiciona um usuario ao banco de dados
        /// </summary>
        /// <param name="UpdateUsuario">Objeto com os campos necessários para criação de um filme</param>
        /// <returns>IActionResult</returns>
        /// <response code="204">Caso inserção seja feita com sucesso</response>


        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        //retornando de acordo com o VERBO HTTP, então adicionamos o IACTIONRESULT
        public IActionResult RecuperaUsuario(int id, [FromBody] UpdateUsuario updateusuario)
        {

            //usuario que eu estou buscando tem o ID igual ao o Parametro recebido;
            var user = context.CadastroDeUsuarios.FirstOrDefault(usuarios => usuarios.Id == id);

            if (user == null) return NotFound();

            //passando os valores;
            user.Nome = updateusuario.Nome;
            user.Senha = updateusuario.Senha;
            user.Email = updateusuario.Email;

      
            //salvando no banco;
            context.SaveChanges();


            return NoContent();

            //Status 201,404
        }

        /// <summary>
        /// apagando um usuario ao banco de dados
        /// </summary>
        /// <param name="id">Objeto com os campos necessários para criação de um filme</param>
        /// <returns>IActionResult</returns>
        /// <response code="204">Caso inserção seja feita com sucesso</response>

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]

        //retornando de acordo com o VERBO HTTP, então adicionamos o IACTIONRESULT
        public IActionResult deletausuario(int id)
        {

            //usuario que eu estou buscando tem o ID igual ao o Parametro recebido;
            var user = context.CadastroDeUsuarios.FirstOrDefault(usuarios => usuarios.Id == id);

            if (user == null) return NotFound();

            //passando os valores;
           

            context.Remove(user);
            context.SaveChanges();


            return NoContent();

            //Status 201,404
        }



        //[HttpGet("Exibindoporpaginacao")]
        //   public IEnumerable<Testebanco> Exibindoporpaginacao([FromQuery] int skip, [FromQuery] int take)
        //{

        //    //skip pula e take pegaaa, quando tiver muita informação ;
        //  return  usuarios.Skip(skip).Take(take);
        //}


    }

}
