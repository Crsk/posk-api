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
    public class SyncsController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Syncs
        [HttpGet]
        public List<Syncs> Get() => db.Syncs.ToList();

        // GET api/Syncs/5
        [HttpGet("{id}")]
        public Syncs Get(int id) => db.Syncs.Find(id);

        // POST api/Syncs
        [HttpPost]
        public void Post(Syncs sync)
        {
            db.Syncs.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Syncs/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Syncs newObj)
        {
            var oldObj = db.Syncs.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Syncs/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Syncs.Remove(db.Syncs.Find(id));
            db.SaveChanges();
        }
    }
}
