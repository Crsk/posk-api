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
    public class ProductoPreparacionController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/ProductoPreparacion
        [HttpGet]
        public List<ProductoPreparacion> Get() => db.ProductoPreparacion.ToList();

        // GET api/ProductoPreparacion/5
        [HttpGet("{id}")]
        public ProductoPreparacion Get(int id) => db.ProductoPreparacion.Find(id);

        // POST api/ProductoPreparacion
        [HttpPost]
        public void Post(ProductoPreparacion sync)
        {
            db.ProductoPreparacion.Add(sync);
            db.SaveChanges();
        }

        // PUT api/ProductoPreparacion/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProductoPreparacion newObj)
        {
            var oldObj = db.ProductoPreparacion.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/ProductoPreparacion/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.ProductoPreparacion.Remove(db.ProductoPreparacion.Find(id));
            db.SaveChanges();
        }
    }
}
