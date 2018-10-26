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
    public class MesasController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Mesas
        [HttpGet]
        public List<Mesas> Get() => db.Mesas.ToList();

        // GET api/Mesas/5
        [HttpGet("{id}")]
        public Mesas Get(int id) => db.Mesas.Find(id);

        // POST api/Mesas
        [HttpPost]
        public void Post(Mesas sync)
        {
            db.Mesas.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Mesas/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mesas newObj)
        {
            var oldObj = db.Mesas.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Mesas/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Mesas.Remove(db.Mesas.Find(id));
            db.SaveChanges();
        }
    }
}
