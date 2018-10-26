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
    public class SalsaController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Salsa
        [HttpGet]
        public List<Salsa> Get() => db.Salsa.ToList();

        // GET api/Salsa/5
        [HttpGet("{id}")]
        public Salsa Get(int id) => db.Salsa.Find(id);

        // POST api/Salsa
        [HttpPost]
        public void Post(Salsa sync)
        {
            db.Salsa.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Salsa/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Salsa newObj)
        {
            var oldObj = db.Salsa.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Salsa/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Salsa.Remove(db.Salsa.Find(id));
            db.SaveChanges();
        }
    }
}
