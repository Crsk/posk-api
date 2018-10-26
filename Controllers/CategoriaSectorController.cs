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
    public class CategoriaSectorController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/CategoriaSector
        [HttpGet]
        public List<CategoriaSector> Get() => db.CategoriaSector.ToList();

        // GET api/CategoriaSector/5
        [HttpGet("{id}")]
        public CategoriaSector Get(int id) => db.CategoriaSector.Find(id);

        // POST api/CategoriaSector
        [HttpPost]
        public void Post(CategoriaSector sync)
        {
            db.CategoriaSector.Add(sync);
            db.SaveChanges();
        }

        // PUT api/CategoriaSector/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CategoriaSector newObj)
        {
            var oldObj = db.CategoriaSector.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/CategoriaSector/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.CategoriaSector.Remove(db.CategoriaSector.Find(id));
            db.SaveChanges();
        }
    }
}
