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
    public class Usuario1Controller : ControllerBase
    {
        private readonly AppDbContext context;

        public Usuario1Controller(AppDbContext context)
        {
            this.context = context;
        }
        // GET: api/<Usuario1Controller>
        [HttpGet]
        public IEnumerable<Usuario1> Get()
        {
            return context.Usuario1.ToList();
        }

        // GET api/<Usuario1Controller>/5
        [HttpGet("{ID}")]
        public Usuario1 Get(int ID)
        {
            var Usuario = context.Usuario1.FirstOrDefault(x => x.ID == ID);

            return Usuario;

        }

        // POST api/<Usuario1Controller>
        [HttpPost]
        public ActionResult Post([FromBody] Usuario1 usuario1)
        {
            try
            {
                context.Usuario1.Add(usuario1);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        // PUT api/<Usuario1Controller>/5
        [HttpPut("{ID}")]
        public ActionResult Put(int ID, [FromBody] Usuario1 usuario1)
        {
            try
            {
                if (usuario1.ID == ID)
                {
                    context.Entry(usuario1).State = EntityState.Modified;
                    context.SaveChanges();

                }
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        // DELETE api/<Usuario1Controller>/5
        [HttpDelete("{ID}")]
        public ActionResult Delete(int ID)
        {
            try
            {
                var usuario1 = context.Usuario1.FirstOrDefault(x => x.ID == ID);
                if (usuario1 != null)
                {
                    context.Usuario1.Remove(usuario1);
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
