using Microsoft.AspNetCore.Mvc;
using Senai.Personagem.WebApi.Manha.Domains;
using Senai.Personagem.WebApi.Manha.Interfaces;
using Senai.Personagem.WebApi.Manha.Repositories;

namespace Senai.Personagem.WebApi.Manha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonagensController : ControllerBase
    {

        private IPersonagemRepository PersonagemRepository { get; set; }

        public PersonagensController()
        {
            PersonagemRepository = new PersonagemRepository();
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(PersonagemRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            PersonagemDomain instituicao = PersonagemRepository.BuscarPorId(id);
            if (instituicao == null)
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpPost]
        public IActionResult Post(PersonagemDomain instituicao)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(PersonagemDomain instituicao)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}