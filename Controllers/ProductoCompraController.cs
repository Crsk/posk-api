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
    public class ProductoCompraController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/ProductoCompra
        [HttpGet]
        public List<ProductoCompra> Get() => db.ProductoCompra.ToList();

        // GET api/ProductoCompra/5
        [HttpGet("{id}")]
        public ProductoCompra Get(int id) => db.ProductoCompra.Find(id);

        // POST api/ProductoCompra
        [HttpPost]
        public void Post(ProductoCompra sync)
        {
            db.ProductoCompra.Add(sync);
            db.SaveChanges();
        }

        // PUT api/ProductoCompra/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProductoCompra newObj)
        {
            var oldObj = db.ProductoCompra.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/ProductoCompra/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.ProductoCompra.Remove(db.ProductoCompra.Find(id));
            db.SaveChanges();
        }
    }
}
