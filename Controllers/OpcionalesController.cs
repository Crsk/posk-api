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
    public class OpcionalesController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Opcionales
        [HttpGet]
        public List<Opcionales> Get() => db.Opcionales.ToList();

        // GET api/Opcionales/5
        [HttpGet("{id}")]
        public Opcionales Get(int id) => db.Opcionales.Find(id);

        // POST api/Opcionales
        [HttpPost]
        public void Post(Opcionales sync)
        {
            db.Opcionales.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Opcionales/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Opcionales newObj)
        {
            var oldObj = db.Opcionales.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Opcionales/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Opcionales.Remove(db.Opcionales.Find(id));
            db.SaveChanges();
        }
    }
}
