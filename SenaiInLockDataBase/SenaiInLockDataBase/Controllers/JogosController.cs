using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SenaiInLockDataBase.Domains;
using SenaiInLockDataBase.Interfaces;
using SenaiInLockDataBase.Repository;

namespace SenaiInLockDataBase.Controllers
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
        public IActionResult Post(Jogos jogos)
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


    }
}