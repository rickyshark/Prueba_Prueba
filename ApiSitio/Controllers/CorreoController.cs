using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiSitio.Contexts;
using ApiSitio.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiSitio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorreoController : ControllerBase
    {
        private readonly AppDbContext context;

        public CorreoController(AppDbContext context)
        {
            this.context = context;
        }
        // GET: api/<CorreoController>
        [HttpGet]
        public IEnumerable<Correo> Get()
        {
            return context.Correo.ToList();
        }

        // GET api/<CorreoController>/5
        [HttpGet("{ID}")]
        public Correo Get(int ID)
        {
            var correo = context.Correo.FirstOrDefault(x => x.ID == ID);
            return correo;
        }

        // POST api/<CorreoController>
        [HttpPost]
        public ActionResult Post([FromBody] Correo correo)
        {
            try
            {
                context.Correo.Add(correo);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        // PUT api/<CorreoController>/5
        [HttpPut("{ID}")]
        public ActionResult Put(int ID, [FromBody] Correo correo)
        {
            try
            {
                if (correo.ID == ID)
                {
                    context.Entry(correo).State = EntityState.Modified;
                    context.SaveChanges();
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        // DELETE api/<CorreoController>/5
        [HttpDelete("{ID}")]
        public ActionResult Delete(int ID)
        {
            try
            {
                var categoria = context.Correo.FirstOrDefault(x => x.ID == ID);
                if (categoria != null)
                {
                    context.Correo.Remove(categoria);
                    context.SaveChanges();
                }
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
