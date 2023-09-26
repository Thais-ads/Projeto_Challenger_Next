using API_ARTCHER.Data;
using API_ARTCHER.Data.DTO;
using API_ARTCHER.Models;
//using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace API_ARTCHER.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class CadastroFilialController: ControllerBase
    {



        // injeção dependence
        private CadastroContext context;
        //private IMapper _mapper;


        public CadastroFilialController(CadastroContext teste/*, IMapper mapper*/)
        {
            context = teste;
            //_mapper = mapper;
        }

        /// <summary>
        /// Adiciona um filme ao banco de dados
        /// </summary>
        /// <param name="FilialDto">Objeto com os campos necessários para criação de um filme</param>
        /// <returns>IActionResult</returns>
        /// <response code="201">Caso inserção seja feita com sucesso</response>
        [HttpPost("CadastrandoUsuario")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult CadastroFilial( [FromBody]  FilialDto dto)
        {


            CadastroFilial testebanco = new CadastroFilial 
            { 
                NomeDaFilial = dto.NomeDaFilial,
                Contato = dto.Contato,
                Endereco = dto.Endereco,
                Numero = dto.Numero,
                Bairro = dto.Bairro,
                Descricao = dto.Descriacao,
                Foto = dto.Foto,
                Data= dto.Data

            };


                context.Add(testebanco);
                context.SaveChanges();

                return Ok(testebanco);
                //Status 200,201
            
            
            //Testebanco testebanco = _mapper.Map<Testebanco>(dto);



        }

        /// <summary>
        /// Adiciona um filme ao banco de dados
        /// </summary>
        /// <param name="FilialDto">Objeto com os campos necessários para criação de um filme</param>
        /// <returns>IActionResult</returns>
        /// <response code="204">Caso inserção seja feita com sucesso</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult AtualizarFilial(int id, [FromBody] FilialDto dto)
        {
            var filial = context.CadastroFilials.FirstOrDefault(filial => filial.Id == id);
            if (filial == null) return NotFound();

            filial.NomeDaFilial = dto.NomeDaFilial;
            filial.Contato = dto.Contato;
            filial.Endereco = dto.Endereco;
            filial.Numero = dto.Numero;
            filial.Bairro = dto.Bairro;
            filial.Descricao = dto.Descriacao;
            filial.Foto = dto.Foto;
            
            context.SaveChanges();

            return NoContent();
        }

        /// <summary>
        /// Adiciona um filme ao banco de dados
        /// </summary>
        /// <param name="id">Objeto com os campos necessários para criação de um filme</param>
        /// <returns>IActionResult</returns>
        /// <response code="200">Caso inserção seja feita com sucesso</response>


        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        //retornando de acordo com o VERBO HTTP, então adicionamos o IACTIONRESULT
        public IActionResult RecuperaFilialID(int id)
        {

            //usuario que eu estou buscando tem o ID igual ao o Parametro recebido;
            var filial = context.CadastroFilials.FirstOrDefault(filial => filial.Id == id);
            if (filial == null) return NotFound();
            return Ok(filial);



            //Status 201,404
        }
        /// <summary>
        /// Adiciona um filme ao banco de dados
        /// </summary>
        /// <param name="id">Objeto com os campos necessários para criação de um filme</param>
        /// <returns>IActionResult</returns>
        /// <response code="204">Caso inserção seja feita com sucesso</response>

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]

        //retornando de acordo com o VERBO HTTP, então adicionamos o IACTIONRESULT
        public IActionResult DeleteFilialID(int id)
        {

            //usuario que eu estou buscando tem o ID igual ao o Parametro recebido;
            var filial = context.CadastroFilials.FirstOrDefault(filial => filial.Id == id);
            if (filial == null) return NotFound();

            context.Remove(filial);
            context.SaveChanges();
            return NoContent();



            //Status 201,404
        }

    }

}
