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
    public class FiadosController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Fiados
        [HttpGet]
        public List<Fiados> Get() => db.Fiados.ToList();

        // GET api/Fiados/5
        [HttpGet("{id}")]
        public Fiados Get(int id) => db.Fiados.Find(id);

        // POST api/Fiados
        [HttpPost]
        public void Post(Fiados sync)
        {
            db.Fiados.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Fiados/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Fiados newObj)
        {
            var oldObj = db.Fiados.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Fiados/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Fiados.Remove(db.Fiados.Find(id));
            db.SaveChanges();
        }
    }
}
