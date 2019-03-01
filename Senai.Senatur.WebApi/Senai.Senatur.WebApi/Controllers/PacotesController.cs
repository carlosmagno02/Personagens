using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.Repositories;

namespace Senai.Senatur.WebApi.Controllers
{   [Produces("aplication/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PacotesController : ControllerBase
    {
        private IPacoteRepository PacoteRepository { get; set; }

        public PacotesController()
        {
            PacoteRepository = new PacoteRepository();
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(PacoteRepository.Listar());
            }
            catch (System.Exception ex)
            {

                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Post(Pacotes pacotes)
        {
            try
            {


                PacoteRepository.Cadastrar(pacotes);
                return Ok();

            }
            catch (System.Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPut]
        public IActionResult Put(Pacotes pacotes)
        {
            try
            {
                PacoteRepository.Atualizar(pacotes);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

    }
}