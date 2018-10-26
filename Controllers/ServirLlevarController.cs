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
    public class ServirLlevarController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/ServirLlevar
        [HttpGet]
        public List<ServirLlevar> Get() => db.ServirLlevar.ToList();

        // GET api/ServirLlevar/5
        [HttpGet("{id}")]
        public ServirLlevar Get(int id) => db.ServirLlevar.Find(id);

        // POST api/ServirLlevar
        [HttpPost]
        public void Post(ServirLlevar sync)
        {
            db.ServirLlevar.Add(sync);
            db.SaveChanges();
        }

        // PUT api/ServirLlevar/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ServirLlevar newObj)
        {
            var oldObj = db.ServirLlevar.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/ServirLlevar/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.ServirLlevar.Remove(db.ServirLlevar.Find(id));
            db.SaveChanges();
        }
    }
}
