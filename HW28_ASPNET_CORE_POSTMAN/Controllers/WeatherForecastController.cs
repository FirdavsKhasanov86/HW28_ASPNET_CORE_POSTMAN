using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW28_ASPNET_CORE_POSTMAN.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HW28_ASPNET_CORE_POSTMAN.Controllers
{
    [ApiController]
    [Route("api")]
    public class CitatasController : ControllerBase
    {
        DataContext db;

        public CitatasController(DataContext context)
        {
            db = context;
           
        }

        // GET: api/<controller>

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Citata>>> Get()
        {
            return await db.Citatas.ToListAsync();
        }

        // GET api/Citatas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Citata>> Get(int id)
        {
            Citata Citata = await db.Citatas.FirstOrDefaultAsync(x => x.Id == id);
            if (Citata == null)
                return NotFound();
            return new ObjectResult(Citata);
        }

        // POST api/Citatas
        [HttpPost]
        public ActionResult Post(Citata Citata)
        {
            if (Citata == null)
            {
                return BadRequest();
            }
            db.Citatas.Add(Citata);
             db.SaveChanges();
            return Ok();
        }

        // PUT api/Citatas/
        [HttpPut("{id}")]
        public ActionResult Put(Citata Citata, int id)
        {
            if (Citata == null)
            {
                return BadRequest();
            }
            Citata.Id = id;
            if (!db.Citatas.Any(x => x.Id == Citata.Id))
            {
                return NotFound();
            }
            db.Update(Citata);
             db.SaveChanges();
            return Ok();
        }

        // DELETE api/Citatas/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Citata Citata = db.Citatas.FirstOrDefault(x => x.Id == id);
            if (Citata == null)
            {
                return NotFound();
            }
            db.Citatas.Remove(Citata);
             db.SaveChanges();
            return Ok(Citata);
        }
    }
}
