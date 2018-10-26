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
    public class MermasController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Mermas
        [HttpGet]
        public List<Mermas> Get() => db.Mermas.ToList();

        // GET api/Mermas/5
        [HttpGet("{id}")]
        public Mermas Get(int id) => db.Mermas.Find(id);

        // POST api/Mermas
        [HttpPost]
        public void Post(Mermas sync)
        {
            db.Mermas.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Mermas/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mermas newObj)
        {
            var oldObj = db.Mermas.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Mermas/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Mermas.Remove(db.Mermas.Find(id));
            db.SaveChanges();
        }
    }
}
