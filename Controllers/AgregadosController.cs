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
    public class AgregadosController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Agregados
        [HttpGet]
        public List<Agregados> Get() => db.Agregados.ToList();

        // GET api/Agregados/5
        [HttpGet("{id}")]
        public Agregados Get(int id) => db.Agregados.Find(id);

        // POST api/Agregados
        [HttpPost]
        public void Post(Agregados sync)
        {
            db.Agregados.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Agregados/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Agregados newObj)
        {
            var oldObj = db.Agregados.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Agregados/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Agregados.Remove(db.Agregados.Find(id));
            db.SaveChanges();
        }
    }
}
