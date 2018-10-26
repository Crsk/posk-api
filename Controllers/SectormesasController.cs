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
    public class SectormesasController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Sectormesas
        [HttpGet]
        public List<Sectormesas> Get() => db.Sectormesas.ToList();

        // GET api/Sectormesas/5
        [HttpGet("{id}")]
        public Sectormesas Get(int id) => db.Sectormesas.Find(id);

        // POST api/Sectormesas
        [HttpPost]
        public void Post(Sectormesas sync)
        {
            db.Sectormesas.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Sectormesas/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Sectormesas newObj)
        {
            var oldObj = db.Sectormesas.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Sectormesas/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Sectormesas.Remove(db.Sectormesas.Find(id));
            db.SaveChanges();
        }
    }
}
