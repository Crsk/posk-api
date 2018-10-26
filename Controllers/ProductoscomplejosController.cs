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
    public class ProductoscomplejosController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Productoscomplejos
        [HttpGet]
        public List<Productoscomplejos> Get() => db.Productoscomplejos.ToList();

        // GET api/Productoscomplejos/5
        [HttpGet("{id}")]
        public Productoscomplejos Get(int id) => db.Productoscomplejos.Find(id);

        // POST api/Productoscomplejos
        [HttpPost]
        public void Post(Productoscomplejos sync)
        {
            db.Productoscomplejos.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Productoscomplejos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Productoscomplejos newObj)
        {
            var oldObj = db.Productoscomplejos.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Productoscomplejos/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Productoscomplejos.Remove(db.Productoscomplejos.Find(id));
            db.SaveChanges();
        }
    }
}
