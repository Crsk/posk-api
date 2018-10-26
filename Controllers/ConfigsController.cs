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
    public class ConfigsController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Configs
        [HttpGet]
        public List<Configs> Get() => db.Configs.ToList();

        // GET api/Configs/5
        [HttpGet("{id}")]
        public Configs Get(int id) => db.Configs.Find(id);

        // POST api/Configs
        [HttpPost]
        public void Post(Configs sync)
        {
            db.Configs.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Configs/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Configs newObj)
        {
            var oldObj = db.Configs.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Configs/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Configs.Remove(db.Configs.Find(id));
            db.SaveChanges();
        }
    }
}
