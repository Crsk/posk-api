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
    public class ProductoMateriaprimaController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/ProductoMateriaprima
        [HttpGet]
        public List<ProductoMateriaprima> Get() => db.ProductoMateriaprima.ToList();

        // GET api/ProductoMateriaprima/5
        [HttpGet("{id}")]
        public ProductoMateriaprima Get(int id) => db.ProductoMateriaprima.Find(id);

        // POST api/ProductoMateriaprima
        [HttpPost]
        public void Post(ProductoMateriaprima sync)
        {
            db.ProductoMateriaprima.Add(sync);
            db.SaveChanges();
        }

        // PUT api/ProductoMateriaprima/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProductoMateriaprima newObj)
        {
            var oldObj = db.ProductoMateriaprima.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/ProductoMateriaprima/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.ProductoMateriaprima.Remove(db.ProductoMateriaprima.Find(id));
            db.SaveChanges();
        }
    }
}
