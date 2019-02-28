using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SenaiInLockDataBase.Domains;
using System.Linq;

namespace SenaiInLockDataBase.Controllers
{   [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                using (InLockContext ctx = new InLockContext())
                {
                return Ok(ctx.Estudios.ToList());
                }
            }
            catch (System.Exception ex)
            {

                return BadRequest();
            }
        }

        [HttpGet("estudioComJogos")]
        public IActionResult GetEstudioComJogos()
        {
            try
            {
                using (InLockContext ctx = new InLockContext())
                {
                    return Ok(ctx.Estudios.Include("Jogos").ToList());
                }
            }
            catch (System.Exception ex)
            {

                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Post(Estudios estudio)
        {
            try
            {
                using (InLockContext ctx = new InLockContext())
                {
                    ctx.Estudios.Add(estudio);
                    ctx.SaveChanges();
                }
                    return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest();
            }

        }
    }
}