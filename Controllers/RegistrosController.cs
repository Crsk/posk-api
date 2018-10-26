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
    public class RegistrosController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Registros
        [HttpGet]
        public List<Registros> Get() => db.Registros.ToList();

        // GET api/Registros/5
        [HttpGet("{id}")]
        public Registros Get(int id) => db.Registros.Find(id);

        // POST api/Registros
        [HttpPost]
        public void Post(Registros sync)
        {
            db.Registros.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Registros/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Registros newObj)
        {
            var oldObj = db.Registros.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Registros/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Registros.Remove(db.Registros.Find(id));
            db.SaveChanges();
        }
    }
}
