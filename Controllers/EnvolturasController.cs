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
    public class EnvolturasController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Envolturas
        [HttpGet]
        public List<Envolturas> Get() => db.Envolturas.ToList();

        // GET api/Envolturas/5
        [HttpGet("{id}")]
        public Envolturas Get(int id) => db.Envolturas.Find(id);

        // POST api/Envolturas
        [HttpPost]
        public void Post(Envolturas sync)
        {
            db.Envolturas.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Envolturas/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Envolturas newObj)
        {
            var oldObj = db.Envolturas.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Envolturas/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Envolturas.Remove(db.Envolturas.Find(id));
            db.SaveChanges();
        }
    }
}
