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
    public class ProductosController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Productos
        [HttpGet]
        public List<Productos> Get() => db.Productos.ToList();

        // GET api/Productos/5
        [HttpGet("{id}")]
        public Productos Get(int id) => db.Productos.Find(id);

        // POST api/Productos
        [HttpPost]
        public void Post(Productos sync)
        {
            db.Productos.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Productos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Productos newObj)
        {
            var oldObj = db.Productos.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Productos/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Productos.Remove(db.Productos.Find(id));
            db.SaveChanges();
        }
    }
}
