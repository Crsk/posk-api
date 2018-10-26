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
    public class IngresosController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Ingresos
        [HttpGet]
        public List<Ingresos> Get() => db.Ingresos.ToList();

        // GET api/Ingresos/5
        [HttpGet("{id}")]
        public Ingresos Get(int id) => db.Ingresos.Find(id);

        // POST api/Ingresos
        [HttpPost]
        public void Post(Ingresos sync)
        {
            db.Ingresos.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Ingresos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Ingresos newObj)
        {
            var oldObj = db.Ingresos.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Ingresos/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Ingresos.Remove(db.Ingresos.Find(id));
            db.SaveChanges();
        }
    }
}
