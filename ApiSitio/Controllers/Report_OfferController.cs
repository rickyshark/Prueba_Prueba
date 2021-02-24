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
    public class Report_OfferController : ControllerBase
    {
        private readonly AppDbContext context;

        public Report_OfferController(AppDbContext context)
        {
            this.context = context;
        }
        // GET: api/<Report_OfferController>
        [HttpGet]
        public IEnumerable<Report_Offer> Get()
        {
            return context.Report_Offer.ToList();
        }

        // GET api/<Report_OfferController>/5
        [HttpGet("{id}")]
        public Report_Offer Get(int id)
        {
            var report = context.Report_Offer.FirstOrDefault(x => x.Id == id);
            return report;
        }

        // POST api/<Report_OfferController>
        [HttpPost]
        public ActionResult Post([FromBody] Report_Offer report)
        {
            try
            {
                context.Report_Offer.Add(report);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }

        }

        // PUT api/<Report_OfferController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Report_Offer report)
        {
            try
            {
                if (report.Id == id)
                {
                    context.Entry(report).State = EntityState.Modified;
                    context.SaveChanges();
                }
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<Report_OfferController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var report_O = context.Report_Offer.FirstOrDefault(x => x.Id == id);
                if (report_O != null)
                {
                    context.Report_Offer.Remove(report_O);
                    context.SaveChanges();
                }
                return Ok();
             
            }
            catch (Exception)
            {
                return BadRequest();
              
            }
        }

    }
}
