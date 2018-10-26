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
    public class SectoresController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Sectores
        [HttpGet]
        public List<Sectores> Get() => db.Sectores.ToList();

        // GET api/Sectores/5
        [HttpGet("{id}")]
        public Sectores Get(int id) => db.Sectores.Find(id);

        // POST api/Sectores
        [HttpPost]
        public void Post(Sectores sync)
        {
            db.Sectores.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Sectores/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Sectores newObj)
        {
            var oldObj = db.Sectores.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Sectores/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Sectores.Remove(db.Sectores.Find(id));
            db.SaveChanges();
        }
    }
}
