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
    public class GastosController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Gastos
        [HttpGet]
        public List<Gastos> Get() => db.Gastos.ToList();

        // GET api/Gastos/5
        [HttpGet("{id}")]
        public Gastos Get(int id) => db.Gastos.Find(id);

        // POST api/Gastos
        [HttpPost]
        public void Post(Gastos sync)
        {
            db.Gastos.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Gastos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Gastos newObj)
        {
            var oldObj = db.Gastos.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Gastos/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Gastos.Remove(db.Gastos.Find(id));
            db.SaveChanges();
        }
    }
}
