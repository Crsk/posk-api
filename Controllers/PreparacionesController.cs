using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PoskApi.Models;
using System.IO;
using System.Net;

namespace PoskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreparacionesController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Preparaciones
        [HttpGet]
        public List<Preparaciones> Get() => db.Preparaciones.ToList();

        // GET api/Preparaciones/5
        [HttpGet("{id}")]
        public Preparaciones Get(int id) => db.Preparaciones.Find(id);

        // POST api/Preparaciones
        [HttpPost]
        public void Post(Preparaciones sync)
        {
            db.Preparaciones.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Preparaciones/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Preparaciones newObj)
        {
            var oldObj = db.Preparaciones.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Preparaciones/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Preparaciones.Remove(db.Preparaciones.Find(id));
            db.SaveChanges();
        }
    }
}
