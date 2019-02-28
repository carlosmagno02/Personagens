using System;
using Microsoft.AspNetCore.Mvc;
using Senai.InLock.CodeFirst.WebApi.Manha.Domains;
using Senai.InLock.CodeFirst.WebApi.Manha.Interfaces;
using Senai.InLock.CodeFirst.WebApi.Manha.Repositories;

namespace Senai.InLock.CodeFirst.WebApi.Manha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogosController : ControllerBase
    {
        private IJogoRepository JogoRepository { get; set; }

        public JogosController()
        {
            JogoRepository = new JogoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(JogoRepository.Listar());
            }
            catch (System.Exception ex)
            {

                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Post(JogoDomain jogos)
        {
            try
            {


                JogoRepository.Cadastrar(jogos);
                return Ok();

            }
            catch (System.Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Put(JogoDomain jogo)
        {
            try
            {
                JogoRepository.Alterar(jogo);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        
    }
}