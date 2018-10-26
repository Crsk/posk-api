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
    public class CantidadesvendidasController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Cantidadesvendidas
        [HttpGet]
        public List<Cantidadesvendidas> Get() => db.Cantidadesvendidas.ToList();

        // GET api/Cantidadesvendidas/5
        [HttpGet("{id}")]
        public Cantidadesvendidas Get(int id) => db.Cantidadesvendidas.Find(id);

        // POST api/Cantidadesvendidas
        [HttpPost]
        public void Post(Cantidadesvendidas sync)
        {
            db.Cantidadesvendidas.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Cantidadesvendidas/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cantidadesvendidas newObj)
        {
            var oldObj = db.Cantidadesvendidas.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Cantidadesvendidas/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Cantidadesvendidas.Remove(db.Cantidadesvendidas.Find(id));
            db.SaveChanges();
        }
    }
}
