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
    public class DevolucionController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Devolucion
        [HttpGet]
        public List<Devolucion> Get() => db.Devolucion.ToList();

        // GET api/Devolucion/5
        [HttpGet("{id}")]
        public Devolucion Get(int id) => db.Devolucion.Find(id);

        // POST api/Devolucion
        [HttpPost]
        public void Post(Devolucion sync)
        {
            db.Devolucion.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Devolucion/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Devolucion newObj)
        {
            var oldObj = db.Devolucion.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Devolucion/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Devolucion.Remove(db.Devolucion.Find(id));
            db.SaveChanges();
        }
    }
}
