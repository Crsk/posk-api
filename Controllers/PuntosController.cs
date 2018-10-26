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
    public class PuntosController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Puntos
        [HttpGet]
        public List<Puntos> Get() => db.Puntos.ToList();

        // GET api/Puntos/5
        [HttpGet("{id}")]
        public Puntos Get(int id) => db.Puntos.Find(id);

        // POST api/Puntos
        [HttpPost]
        public void Post(Puntos sync)
        {
            db.Puntos.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Puntos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Puntos newObj)
        {
            var oldObj = db.Puntos.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Puntos/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Puntos.Remove(db.Puntos.Find(id));
            db.SaveChanges();
        }
    }
}
