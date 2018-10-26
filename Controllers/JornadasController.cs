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
    public class JornadasController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Jornadas
        [HttpGet]
        public List<Jornadas> Get() => db.Jornadas.ToList();

        // GET api/Jornadas/5
        [HttpGet("{id}")]
        public Jornadas Get(int id) => db.Jornadas.Find(id);

        // POST api/Jornadas
        [HttpPost]
        public void Post(Jornadas sync)
        {
            db.Jornadas.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Jornadas/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Jornadas newObj)
        {
            var oldObj = db.Jornadas.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Jornadas/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Jornadas.Remove(db.Jornadas.Find(id));
            db.SaveChanges();
        }
    }
}
