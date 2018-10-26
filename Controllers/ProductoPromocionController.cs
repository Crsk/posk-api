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
    public class ProductoPromocionController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/ProductoPromocion
        [HttpGet]
        public List<ProductoPromocion> Get() => db.ProductoPromocion.ToList();

        // GET api/ProductoPromocion/5
        [HttpGet("{id}")]
        public ProductoPromocion Get(int id) => db.ProductoPromocion.Find(id);

        // POST api/ProductoPromocion
        [HttpPost]
        public void Post(ProductoPromocion sync)
        {
            db.ProductoPromocion.Add(sync);
            db.SaveChanges();
        }

        // PUT api/ProductoPromocion/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProductoPromocion newObj)
        {
            var oldObj = db.ProductoPromocion.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/ProductoPromocion/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.ProductoPromocion.Remove(db.ProductoPromocion.Find(id));
            db.SaveChanges();
        }
    }
}
